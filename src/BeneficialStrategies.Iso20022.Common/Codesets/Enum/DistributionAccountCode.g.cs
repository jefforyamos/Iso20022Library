﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DistributionAccountCode.  ISO2002 ID# _1oiLwDL3EeKU9IrkkToqcw_-1432180896.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account where the disbursed CUSIP will be allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oiLwDL3EeKU9IrkkToqcw_-1432180896")]
[Description(@"Specifies the type of account where the disbursed CUSIP will be allocated.")]
[Derivations(typeof(DistributionAccount1Code))]
// External derivations that should be provided by the proper interface are: 
public enum DistributionAccountCode
{
    /// <summary>
    /// General free account. DTC (The Depository Trust Company) allows immediate use of securities.
    /// Encoded/decoded by serializers as "GENF".
    /// </summary>
    [EnumMember(Value = "GENF")]
    [IsoId("_1oiLwTL3EeKU9IrkkToqcw_1225892924")]
    [Description(@"General free account. DTC (The Depository Trust Company) allows immediate use of securities.")]
    GeneralFree,
    
    /// <summary>
    /// RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities.
    /// Encoded/decoded by serializers as "RRGA".
    /// </summary>
    [EnumMember(Value = "RRGA")]
    [IsoId("_1oiLwjL3EeKU9IrkkToqcw_1657827283")]
    [Description(@"RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities.")]
    RRGAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DistributionAccountCodeMetadataExtensions
{
    private static readonly DistributionAccountCodeDropdownSource _dropdownSource = new DistributionAccountCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDistributionAccountCodeDropdownRow GetMetadata(this DistributionAccountCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


