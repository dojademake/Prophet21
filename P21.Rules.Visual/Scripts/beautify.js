function beautifyXml(xml) {
    var reg = /(>)(<)(\/*)/g;
    var wsexp = / *(.*) +\n/g;
    var contexp = /(<.+>)(.+\n)/g;
    xml = xml.replace(reg, '$1\n$2$3').replace(wsexp, '$1\n').replace(contexp, '$1\n$2');
    var pad = 0;
    var formatted = '';
    var lines = xml.split('\n');
    var indent = 0;
    var lastType = 'other';
    var transitions = {
        'single->single': 0,
        'single->closing': -1,
        'single->opening': 0,
        'single->other': 0,
        'closing->single': 0,
        'closing->closing': -1,
        'closing->opening': 0,
        'closing->other': 0,
        'opening->single': 1,
        'opening->closing': 0,
        'opening->opening': 1,
        'opening->other': 1,
        'other->single': 1,
        'other->closing': 0,
        'other->opening': 1,
        'other->other': 1
    };

    for (var i = 0; i < lines.length; i++) {
        var ln = lines[i];
        var single = Boolean(ln.match(/<.+\/>/));
        var closing = Boolean(ln.match(/<\/.+>/));
        var opening = Boolean(ln.match(/<[^!].*>/));
        var type = single ? 'single' : closing ? 'closing' : opening ? 'opening' : 'other';
        var fromTo = lastType + '->' + type;
        lastType = type;
        var padding = '';

        indent += transitions[fromTo];
        for (var j = 0; j < indent; j++) {
            padding += '    ';
        }
        if (fromTo == 'opening->closing')
            formatted = formatted.substr(0, formatted.length - 1) + ln + '\n';
        else
            formatted += padding + ln + '\n';
    }

    return formatted;
}


function formatXml(xml) {
    var reg = /(>)(<)(\/*)/g;
    xml = xml.replace(reg, '$1\r\n$2$3');
    var formatted = '';
    var pad = 0;
    xml.split('\r\n').forEach(function (node) {
        var indent = 0;
        if (node.match(/.+<\/\w[^>]*>$/)) {
            indent = 0;
        } else if (node.match(/^<\/\w/)) {
            if (pad !== 0) {
                pad -= 1;
            }
        } else if (node.match(/^<\w[^>]*[^/]>/)) {
            indent = 1;
        }
        var padding = '';
        for (var i = 0; i < pad; i++) {
            padding += '  ';
        }
        formatted += padding + node + '\r\n';
        pad += indent;
    });
    return formatted;
}
