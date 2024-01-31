﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DebtInstrumentSeniorityTypeCode.  ISO2002 ID# _Uq4csc4tEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the seniority type of a specific debt instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Uq4csc4tEeSc85GUbgBycw")]
[Description(@"Specifies the seniority type of a specific debt instrument.")]
[Derivations(typeof(DebtInstrumentSeniorityType1Code),typeof(DebtInstrumentSeniorityType2Code))]
public enum DebtInstrumentSeniorityTypeCode
{
    /// <summary>
    /// Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.
    /// Encoded/decoded by serializers as "SNDB".
    /// </summary>
    [EnumMember(Value = "SNDB")]
    [IsoId("_c5p08M4tEeSc85GUbgBycw")]
    [Description(@"Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.")]
    SeniorDebt,
    
    /// <summary>
    /// Subordinated debt or preferred equity instrument that represents a claim on a company's assets which is senior only to that of the common shares.
    /// Encoded/decoded by serializers as "MZZD".
    /// </summary>
    [EnumMember(Value = "MZZD")]
    [IsoId("_c8oQcM4tEeSc85GUbgBycw")]
    [Description(@"Subordinated debt or preferred equity instrument that represents a claim on a company's assets which is senior only to that of the common shares.")]
    MezzanineDebt,
    
    /// <summary>
    /// Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.
    /// Encoded/decoded by serializers as "SBOD".
    /// </summary>
    [EnumMember(Value = "SBOD")]
    [IsoId("_dAWS0M4tEeSc85GUbgBycw")]
    [Description(@"Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.")]
    SubordinatedDebt,
    
    /// <summary>
    /// Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property.
    /// Encoded/decoded by serializers as "JUND".
    /// </summary>
    [EnumMember(Value = "JUND")]
    [IsoId("_dGAO4M4tEeSc85GUbgBycw")]
    [Description(@"Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property.")]
    JuniorDebt,
    
    /// <summary>
    /// Other type of debts.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VTTZsEEPEeWwF-kIleVYXQ")]
    [Description(@"Other type of debts.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DebtInstrumentSeniorityTypeCodeMetadataExtensions
{
    private static readonly DebtInstrumentSeniorityTypeCodeDropdownSource _dropdownSource = new DebtInstrumentSeniorityTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDebtInstrumentSeniorityTypeCodeDropdownRow GetMetadata(this DebtInstrumentSeniorityTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


