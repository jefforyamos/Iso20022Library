﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxEfficientProductTypeCode.  ISO2002 ID# _X-nhUE4LEeiQHa-q1Uephw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of tax efficient product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X-nhUE4LEeiQHa-q1Uephw")]
[Description(@"Specifies a type of tax efficient product.")]
public enum TaxEfficientProductTypeCode
{
    /// <summary>
    /// Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_iN-RQE4LEeiQHa-q1Uephw")]
    [Description(@"Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.")]
    StocksAndShares,
    
    /// <summary>
    /// Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.
    /// Encoded/decoded by serializers as "JISA".
    /// </summary>
    [EnumMember(Value = "JISA")]
    [IsoId("_mkK1cE4LEeiQHa-q1Uephw")]
    [Description(@"Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.")]
    JuniorStocksAndSharesISA,
    
    /// <summary>
    /// Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.
    /// Encoded/decoded by serializers as "SCTF".
    /// </summary>
    [EnumMember(Value = "SCTF")]
    [IsoId("_rFcoQE4LEeiQHa-q1Uephw")]
    [Description(@"Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.")]
    StakeholderChildTrustFund,
    
    /// <summary>
    /// Cash individual savings account. In the UK, this is known as a cash ISA.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uWMnUE4LEeiQHa-q1Uephw")]
    [Description(@"Cash individual savings account. In the UK, this is known as a cash ISA.")]
    Cash,
    
    /// <summary>
    /// Junior cash individual savings account. In the UK, this is known as a cash JISA.
    /// Encoded/decoded by serializers as "JCSH".
    /// </summary>
    [EnumMember(Value = "JCSH")]
    [IsoId("_wlLnYE4LEeiQHa-q1Uephw")]
    [Description(@"Junior cash individual savings account. In the UK, this is known as a cash JISA.")]
    JuniorCash,
    
    /// <summary>
    /// Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.
    /// Encoded/decoded by serializers as "CCTF".
    /// </summary>
    [EnumMember(Value = "CCTF")]
    [IsoId("_66P9wE4LEeiQHa-q1Uephw")]
    [Description(@"Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.")]
    NonStakeholderChildTrustFund,
    
    /// <summary>
    /// Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.
    /// Encoded/decoded by serializers as "LISA".
    /// </summary>
    [EnumMember(Value = "LISA")]
    [IsoId("_ALOIIE4MEeiQHa-q1Uephw")]
    [Description(@"Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.")]
    Lifetime,
    
    /// <summary>
    /// Innovative finance individual savings account. In the UK, this is known as an innovative ISA.
    /// Encoded/decoded by serializers as "INNF".
    /// </summary>
    [EnumMember(Value = "INNF")]
    [IsoId("_C4iqAE4MEeiQHa-q1Uephw")]
    [Description(@"Innovative finance individual savings account. In the UK, this is known as an innovative ISA.")]
    InnovativeFinance,
    
    /// <summary>
    /// Help to buy individual savings account. In the UK, this is known as a HISA.
    /// Encoded/decoded by serializers as "HISA".
    /// </summary>
    [EnumMember(Value = "HISA")]
    [IsoId("_IcZ7ME4MEeiQHa-q1Uephw")]
    [Description(@"Help to buy individual savings account. In the UK, this is known as a HISA.")]
    HelpToBuy,
    
    /// <summary>
    /// Flexible individual savings account. In the UK, this is known as a FISA.
    /// Encoded/decoded by serializers as "FISA".
    /// </summary>
    [EnumMember(Value = "FISA")]
    [IsoId("_LEYDAE4MEeiQHa-q1Uephw")]
    [Description(@"Flexible individual savings account. In the UK, this is known as a FISA.")]
    Flexible,
    
    /// <summary>
    /// General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)
    /// Encoded/decoded by serializers as "GISK".
    /// </summary>
    [EnumMember(Value = "GISK")]
    [IsoId("__V6XgKFfEei_VZq-6SQkuQ")]
    [Description(@"General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)")]
    GeneralInvestmentSavingsAccount,
    
    /// <summary>
    /// General shares or equity savings account. (Known as ASK in some markets.)
    /// Encoded/decoded by serializers as "GASK".
    /// </summary>
    [EnumMember(Value = "GASK")]
    [IsoId("_tmQZYKVFEeiYMvosZPzV4g")]
    [Description(@"General shares or equity savings account. (Known as ASK in some markets.)")]
    GeneralShareSavingsAccount,
    
    /// <summary>
    /// Cash lifetime individual savings account. In the UK, this is known as a cash LISA.
    /// Encoded/decoded by serializers as "CLIS".
    /// </summary>
    [EnumMember(Value = "CLIS")]
    [IsoId("_etwKMJNtEemQB_8XA98K0Q")]
    [Description(@"Cash lifetime individual savings account. In the UK, this is known as a cash LISA.")]
    CashLISA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxEfficientProductTypeCodeMetadataExtensions
{
    private static readonly TaxEfficientProductTypeCodeDropdownSource _dropdownSource = new TaxEfficientProductTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxEfficientProductTypeCodeDropdownRow GetMetadata(this TaxEfficientProductTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


