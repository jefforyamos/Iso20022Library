﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxEfficientProductType2Code.  ISO2002 ID# _qS2hUJy-Eem54rMzia0iag.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of tax efficient product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qS2hUJy-Eem54rMzia0iag")]
[Description(@"Specifies a type of tax efficient product.")]
[DerivedFrom(typeof(TaxEfficientProductTypeCode))]
public enum TaxEfficientProductType2Code
{
    /// <summary>
    /// Cash individual savings account. In the UK, this is known as a cash ISA.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_sDLPcZy-Eem54rMzia0iag")]
    [Description(@"Cash individual savings account. In the UK, this is known as a cash ISA.")]
    Cash,
    
    /// <summary>
    /// Cash lifetime individual savings account. In the UK, this is known as a cash LISA.
    /// Encoded/decoded by serializers as "CashLISA".
    /// </summary>
    [EnumMember(Value = "CLIS")]
    [IsoId("_sOMMoZy-Eem54rMzia0iag")]
    [Description(@"Cash lifetime individual savings account. In the UK, this is known as a cash LISA.")]
    CashLISA,
    
    /// <summary>
    /// Flexible individual savings account. In the UK, this is known as a FISA.
    /// Encoded/decoded by serializers as "Flexible".
    /// </summary>
    [EnumMember(Value = "FISA")]
    [IsoId("_sUu5gZy-Eem54rMzia0iag")]
    [Description(@"Flexible individual savings account. In the UK, this is known as a FISA.")]
    Flexible,
    
    /// <summary>
    /// General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)
    /// Encoded/decoded by serializers as "GeneralInvestmentSavingsAccount".
    /// </summary>
    [EnumMember(Value = "GISK")]
    [IsoId("_sa1hgZy-Eem54rMzia0iag")]
    [Description(@"General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)")]
    GeneralInvestmentSavingsAccount,
    
    /// <summary>
    /// General shares or equity savings account. (Known as ASK in some markets.)
    /// Encoded/decoded by serializers as "GeneralShareSavingsAccount".
    /// </summary>
    [EnumMember(Value = "GASK")]
    [IsoId("_skM44Zy-Eem54rMzia0iag")]
    [Description(@"General shares or equity savings account. (Known as ASK in some markets.)")]
    GeneralShareSavingsAccount,
    
    /// <summary>
    /// Help to buy individual savings account. In the UK, this is known as a HISA.
    /// Encoded/decoded by serializers as "HelpToBuy".
    /// </summary>
    [EnumMember(Value = "HISA")]
    [IsoId("_spaJAZy-Eem54rMzia0iag")]
    [Description(@"Help to buy individual savings account. In the UK, this is known as a HISA.")]
    HelpToBuy,
    
    /// <summary>
    /// Innovative finance individual savings account. In the UK, this is known as an innovative ISA.
    /// Encoded/decoded by serializers as "InnovativeFinance".
    /// </summary>
    [EnumMember(Value = "INNF")]
    [IsoId("_svqiAZy-Eem54rMzia0iag")]
    [Description(@"Innovative finance individual savings account. In the UK, this is known as an innovative ISA.")]
    InnovativeFinance,
    
    /// <summary>
    /// Junior cash individual savings account. In the UK, this is known as a cash JISA.
    /// Encoded/decoded by serializers as "JuniorCash".
    /// </summary>
    [EnumMember(Value = "JCSH")]
    [IsoId("_s4u-cZy-Eem54rMzia0iag")]
    [Description(@"Junior cash individual savings account. In the UK, this is known as a cash JISA.")]
    JuniorCash,
    
    /// <summary>
    /// Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.
    /// Encoded/decoded by serializers as "JuniorStocksAndSharesISA".
    /// </summary>
    [EnumMember(Value = "JISA")]
    [IsoId("_s-irgZy-Eem54rMzia0iag")]
    [Description(@"Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.")]
    JuniorStocksAndSharesISA,
    
    /// <summary>
    /// Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.
    /// Encoded/decoded by serializers as "Lifetime".
    /// </summary>
    [EnumMember(Value = "LISA")]
    [IsoId("_tEfigZy-Eem54rMzia0iag")]
    [Description(@"Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.")]
    Lifetime,
    
    /// <summary>
    /// Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.
    /// Encoded/decoded by serializers as "NonStakeholderChildTrustFund".
    /// </summary>
    [EnumMember(Value = "CCTF")]
    [IsoId("_tM-JEZy-Eem54rMzia0iag")]
    [Description(@"Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.")]
    NonStakeholderChildTrustFund,
    
    /// <summary>
    /// Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.
    /// Encoded/decoded by serializers as "StakeholderChildTrustFund".
    /// </summary>
    [EnumMember(Value = "SCTF")]
    [IsoId("_tS7AEZy-Eem54rMzia0iag")]
    [Description(@"Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.")]
    StakeholderChildTrustFund,
    
    /// <summary>
    /// Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.
    /// Encoded/decoded by serializers as "StocksAndShares".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_tZ6Y4Zy-Eem54rMzia0iag")]
    [Description(@"Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.")]
    StocksAndShares,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxEfficientProductType2CodeMetadataExtensions
{
    private static readonly TaxEfficientProductType2CodeDropdownSource _dropdownSource = new TaxEfficientProductType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxEfficientProductType2CodeDropdownRow GetMetadata(this TaxEfficientProductType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


