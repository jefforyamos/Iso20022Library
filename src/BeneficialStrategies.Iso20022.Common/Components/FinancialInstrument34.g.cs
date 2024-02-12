﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument34.  ISO2002 ID# _LcczcRw5EeOIveEnnb_1-A.
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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_LcczcRw5EeOIveEnnb_1-A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Instrument")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument34( SecurityIdentification3Choice_ reqIdentification,TransferType1Code reqTransferType )
    {
        Identification = reqIdentification;
        TransferType = reqTransferType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_L0jxdRw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification3Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification3Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification3Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification3Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_L0jxdxw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    [IsoId("_L0jxeRw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferType1Code TransferType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransferType1Code TransferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferType1Code TransferType { get; init; } 
    #else
    public TransferType1Code TransferType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_L0jxexw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity12Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity12Choice_? Quantity { get; init; } 
    #else
    public Quantity12Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Average cost per share of a security, including all charges and commissions.
    /// </summary>
    [IsoId("_L0jxfRw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Average Acquisition Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AverageAcquisitionPrice { get; init; } 
    #else
    public System.Decimal? AverageAcquisitionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_L0jxfxw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Book Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalBookValue { get; init; } 
    #else
    public System.Decimal? TotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_L0jxgRw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transferee Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account16? TransfereeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account16? TransfereeAccount { get; init; } 
    #else
    public Account16? TransfereeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("_X7r7UBw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Account Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccount1? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccount1? SubAccountDetails { get; init; } 
    #else
    public SubAccount1? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_L0jxgxw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Receiving Agent Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_L0jxhRw5EeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivering Agent Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
