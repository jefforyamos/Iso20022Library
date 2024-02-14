﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation7.  ISO2002 ID# _eaw-ReaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
[IsoId("_eaw-ReaOEd-q8fx_Zl_34A")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [IsoId("_eaw-R-aOEd-q8fx_Zl_34A")]
    [DisplayName("Account Owner Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrTxId")]
    #endif
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerTransactionIdentification { get; init; } 
    #else
    public System.String? AccountOwnerTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_eaw-SeaOEd-q8fx_Zl_34A")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType1Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType1Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType1Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_eaw-S-aOEd-q8fx_Zl_34A")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount13? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [IsoId("_eaw-TeaOEd-q8fx_Zl_34A")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [IsoId("_eaw-T-aOEd-q8fx_Zl_34A")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [IsoId("_eaw-UeaOEd-q8fx_Zl_34A")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [IsoId("_eaw-U-aOEd-q8fx_Zl_34A")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [IsoId("_eaw-VeaOEd-q8fx_Zl_34A")]
    [DisplayName("Cut Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CutOffDt")]
    #endif
    [IsoXmlTag("CutOffDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? CutOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_eaw-V-aOEd-q8fx_Zl_34A")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43Choice_? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43Choice_? Investor { get; init; } 
    #else
    public PartyIdentification43Choice_? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_eaw-WeaOEd-q8fx_Zl_34A")]
    [DisplayName("Delivering Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgPty1")]
    #endif
    [IsoXmlTag("DlvrgPty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; init; } 
    #else
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_eaw-W-aOEd-q8fx_Zl_34A")]
    [DisplayName("Receiving Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgPty1")]
    #endif
    [IsoXmlTag("RcvgPty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; init; } 
    #else
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
