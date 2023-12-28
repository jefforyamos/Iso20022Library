﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionNarrative1Code.  ISO2002 ID# _bK2F0Np-Ed-ak6NoX_4Aeg_24208784.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the narrative type of a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK2F0Np-Ed-ak6NoX_4Aeg_24208784")]
[Description(@"Specifies the narrative type of a corporate action.")]
[DerivedFrom(typeof(CorporateActionNarrativeCode))]
public enum CorporateActionNarrative1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxationConditions".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F0dp-Ed-ak6NoX_4Aeg_24208786")]
    [Description(@"??")]
    TaxationConditions,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegistrationDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F0tp-Ed-ak6NoX_4Aeg_24208815")]
    [Description(@"??")]
    RegistrationDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingTaxReliefCertification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F09p-Ed-ak6NoX_4Aeg_24209063")]
    [Description(@"??")]
    WithholdingTaxReliefCertification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ICSDRefusalOfMarkUpDownConfirmation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F1Np-Ed-ak6NoX_4Aeg_24209085")]
    [Description(@"??")]
    ICSDRefusalOfMarkUpDownConfirmation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ChasingOfPriorAuthorization".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F1dp-Ed-ak6NoX_4Aeg_24209116")]
    [Description(@"??")]
    ChasingOfPriorAuthorization,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConfirmationOfHoldingTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK2F1tp-Ed-ak6NoX_4Aeg_24209125")]
    [Description(@"??")]
    ConfirmationOfHoldingTransfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionNarrative1CodeMetadataExtensions
{
    private static readonly CorporateActionNarrative1CodeDropdownSource _dropdownSource = new CorporateActionNarrative1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionNarrative1CodeDropdownRow GetMetadata(this CorporateActionNarrative1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


