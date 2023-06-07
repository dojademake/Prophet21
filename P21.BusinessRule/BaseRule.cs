using P21.BusinessRule.BLL;
using P21.Extensions.BusinessRule;
using System;

namespace P21.BusinessRule
{
	public abstract class BaseRule : Rule, IDisposable
	{
		private LogicLayer _logic;
		private bool disposedValue;
		internal IRuleLogger Logger { get; private set; }

		internal LogicLayer Logic
		{
			get
			{
				if (_logic == null)
				{
					_logic = new LogicLayer(this, Logger);
				}
				return _logic;
			}
		}

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public override string GetName()
		{
			return this.GetType().Name;
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				disposedValue = true;
			}
		}

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~BaseRule()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }
	}
}