﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BatchRequest4.  ISO2002 ID# _rZAYYU35Eey_VecAUE-C9Q.
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
/// Data to request a Batch service.
/// </summary>
[IsoId("_rZAYYU35Eey_VecAUE-C9Q")]
[DisplayName("Batch Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BatchRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_ahgJgU7aEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Batch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleBtchId")]
    #endif
    [IsoXmlTag("SaleBtchId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleBatchIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleBatchIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_rfZ7UU35Eey_VecAUE-C9Q")]
    [DisplayName("Remove All Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvAllFlg")]
    #endif
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemoveAllFlag { get; init; } 
    #else
    public System.String? RemoveAllFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_rfaiYU35Eey_VecAUE-C9Q")]
    [DisplayName("Transaction To Perform")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxToPrfrm")]
    #endif
    [IsoXmlTag("TxToPrfrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionToPerform4Choice_? TransactionToPerform { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionToPerform4Choice_? TransactionToPerform { get; init; } 
    #else
    public TransactionToPerform4Choice_? TransactionToPerform { get; set; } 
    #endif
    
    
    #nullable disable
    
}
