﻿namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface ICountryCodeDropdownRow : IDropdownRow
{
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid CountryCode value.
/// It is the responsibility of the implementers of this interface to conform to the required specifications.
/// </summary>
public partial interface ICountryCodeDropdownSource : IDropdownDataSource<ICountryCodeDropdownRow>
{
}

