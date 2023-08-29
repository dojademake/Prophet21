# DynaChange&trade; Business Rule focus

![DynaChange&trade; Rules](https://github.com/Epicor/Prophet21/tree/master/Extensibility/P21.Extensions/lib/assets)

This folder contains code for extending Prophet 21 via DynaChange&trade; Business Rules.

## P21.BusinessRule

A package project for custom rules to inherit for simplifying configuration and logging.

### `BaseRule.cs`

Inherit this base class for typical single or multi-row examining and manipulation of values. A typical outcome would be setting the Success flag and Message text.

## BusinessRule.Examples

Sample files inheriting the base rule class modeled after the https://github.com/Epicor/Prophet21/tree/master/Extensibility/P21.Extensions/P21.Extensions.Examples/General repository.

### `ValidDatetime.cs`

This is a single-row Rule that will validate that each field passed in has a proper date format.

### `ValidUrl.cs`

This is a single-row Rule that will validate that each field passed in has a proper URL format.

## OnDemand
