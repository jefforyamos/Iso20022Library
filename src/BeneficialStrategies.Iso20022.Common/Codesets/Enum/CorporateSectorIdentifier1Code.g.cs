﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateSectorIdentifier1Code.  ISO2002 ID# _gj0acFBdEeOenoknK_-H2g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the corporate sector of the counterparty for reporting to trade repositories.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gj0acFBdEeOenoknK_-H2g")]
[Description(@"Identifies the corporate sector of the counterparty for reporting to trade repositories.")]
[DerivedFrom(typeof(CorporateSectorIdentifierCode))]
public enum CorporateSectorIdentifier1Code
{
    /// <summary>
    /// Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU.
    /// Encoded/decoded by serializers as "AlternativeInvestmentFund".
    /// </summary>
    [EnumMember(Value = "L")]
    [IsoId("_h9rJUVBdEeOenoknK_-H2g")]
    [Description(@"Alternative investment fund managed by an Alternative Investment Fund Manager (AIFM) authorised or registered in accordance with European Securities and Markets Authority (ESMA) Directive 2011/61/EU.")]
    AlternativeInvestmentFund,
    
    /// <summary>
    /// Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC.
    /// Encoded/decoded by serializers as "Assurance".
    /// </summary>
    [EnumMember(Value = "A")]
    [IsoId("_iEFTUVBdEeOenoknK_-H2g")]
    [Description(@"Assurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2002/83/EC.")]
    Assurance,
    
    /// <summary>
    /// Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC.
    /// Encoded/decoded by serializers as "CreditInstitution".
    /// </summary>
    [EnumMember(Value = "C")]
    [IsoId("_iKonQVBdEeOenoknK_-H2g")]
    [Description(@"Credit Institution authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2006/48/EC.")]
    CreditInstitution,
    
    /// <summary>
    /// Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC.
    /// Encoded/decoded by serializers as "Insurance".
    /// </summary>
    [EnumMember(Value = "I")]
    [IsoId("_iQJZYVBdEeOenoknK_-H2g")]
    [Description(@"Insurance undertaking in accordance with European Securities and Markets Authority (ESMA) Directive 73/239/EEC.")]
    Insurance,
    
    /// <summary>
    /// Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC.
    /// Encoded/decoded by serializers as "InvestmentFirm".
    /// </summary>
    [EnumMember(Value = "F")]
    [IsoId("_iXc7QVBdEeOenoknK_-H2g")]
    [Description(@"Investment firm in accordance with European Securities and Markets Authority (ESMA) Directive 2004/39/EC.")]
    InvestmentFirm,
    
    /// <summary>
    /// Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC.
    /// Encoded/decoded by serializers as "OccupationalRetirementProvision".
    /// </summary>
    [EnumMember(Value = "O")]
    [IsoId("_ihSMsVBdEeOenoknK_-H2g")]
    [Description(@"Institution for occupational retirement provision within the meaning of Article 6(a) of European Securities and Markets Authority (ESMA) Directive 2003/41/EC.")]
    OccupationalRetirementProvision,
    
    /// <summary>
    /// Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC.
    /// Encoded/decoded by serializers as "Reinsurance".
    /// </summary>
    [EnumMember(Value = "R")]
    [IsoId("_inGg0VBdEeOenoknK_-H2g")]
    [Description(@"Reinsurance undertaking authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2005/68/EC.")]
    Reinsurance,
    
    /// <summary>
    /// Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC.
    /// Encoded/decoded by serializers as "UCITS".
    /// </summary>
    [EnumMember(Value = "U")]
    [IsoId("_itD-4VBdEeOenoknK_-H2g")]
    [Description(@"Undertakings for Collective Investment in Transferable Securities (UCITS) and its management company, authorised in accordance with European Securities and Markets Authority (ESMA) Directive 2009/95/EC.")]
    UCITS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateSectorIdentifier1CodeMetadataExtensions
{
    private static readonly CorporateSectorIdentifier1CodeDropdownSource _dropdownSource = new CorporateSectorIdentifier1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateSectorIdentifier1CodeDropdownRow GetMetadata(this CorporateSectorIdentifier1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


