﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessingType1Code.  ISO2002 ID# _8JT2IaMgEeCJ6YNENx4h-w_-880711812.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of processing restrictions the central system must apply.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8JT2IaMgEeCJ6YNENx4h-w_-880711812")]
[Description(@"Specifies the type of processing restrictions the central system must apply.")]
[DerivedFrom(typeof(ProcessingTypeCode))]
public enum ProcessingType1Code
{
    /// <summary>
    /// Restriction is the rejection during the settlement instruction validation.
    /// Encoded/decoded by serializers as "Rejection".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_8JT2IqMgEeCJ6YNENx4h-w_-393464774")]
    [Description(@"Restriction is the rejection during the settlement instruction validation.")]
    Rejection,
    
    /// <summary>
    /// Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.
    /// Encoded/decoded by serializers as "CSDValidationHold".
    /// </summary>
    [EnumMember(Value = "CVHD")]
    [IsoId("_8JdAAKMgEeCJ6YNENx4h-w_-1779488563")]
    [Description(@"Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.")]
    CSDValidationHold,
    
    /// <summary>
    /// Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.
    /// Encoded/decoded by serializers as "Reservation".
    /// </summary>
    [EnumMember(Value = "RSVT")]
    [IsoId("_8JdAAaMgEeCJ6YNENx4h-w_-739454268")]
    [Description(@"Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.")]
    Reservation,
    
    /// <summary>
    /// Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.
    /// Encoded/decoded by serializers as "Blocking".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_8JdAAqMgEeCJ6YNENx4h-w_-1357372058")]
    [Description(@"Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.")]
    Blocking,
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions.
    /// Encoded/decoded by serializers as "Earmarking".
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_8JdAA6MgEeCJ6YNENx4h-w_927638380")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions.")]
    Earmarking,
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.
    /// Encoded/decoded by serializers as "EarmarkingForAutoCollateralisation".
    /// </summary>
    [EnumMember(Value = "EFAC")]
    [IsoId("_8JdABKMgEeCJ6YNENx4h-w_-1964191071")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.")]
    EarmarkingForAutoCollateralisation,
    
    /// <summary>
    /// No restriction has been defined.
    /// Encoded/decoded by serializers as "Deliverable".
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_8JdABaMgEeCJ6YNENx4h-w_1538040308")]
    [Description(@"No restriction has been defined.")]
    Deliverable,
    
    /// <summary>
    /// Restriction is linked to a sub-pledged collateral transaction.
    /// Encoded/decoded by serializers as "Collateralised".
    /// </summary>
    [EnumMember(Value = "COLD")]
    [IsoId("_8JdABqMgEeCJ6YNENx4h-w_-779072156")]
    [Description(@"Restriction is linked to a sub-pledged collateral transaction.")]
    Collateralised,
    
    /// <summary>
    /// Restriction does not support any partial execution.
    /// Encoded/decoded by serializers as "CoSDBlocking".
    /// </summary>
    [EnumMember(Value = "CSDB")]
    [IsoId("_8JdAB6MgEeCJ6YNENx4h-w_1505938282")]
    [Description(@"Restriction does not support any partial execution.")]
    CoSDBlocking,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessingType1CodeMetadataExtensions
{
    private static readonly ProcessingType1CodeDropdownSource _dropdownSource = new ProcessingType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessingType1CodeDropdownRow GetMetadata(this ProcessingType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


