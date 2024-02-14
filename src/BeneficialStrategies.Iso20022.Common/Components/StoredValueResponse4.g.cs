﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StoredValueResponse4.  ISO2002 ID# _JvBDUS8-Eeu125Ip9zFcsQ.
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
/// Response data to a Stored Value request.
/// </summary>
[IsoId("_JvBDUS8-Eeu125Ip9zFcsQ")]
[DisplayName("Stored Value Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StoredValueResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StoredValueResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StoredValueResponse4( TransactionIdentifier1 reqPOITransactionIdentification )
    {
        POITransactionIdentification = reqPOITransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_J8FO8S8-Eeu125Ip9zFcsQ")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_J8FO8y8-Eeu125Ip9zFcsQ")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueData4? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueData4? Result { get; init; } 
    #else
    public StoredValueData4? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_J8FO9S8-Eeu125Ip9zFcsQ")]
    [DisplayName("Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rct")]
    #endif
    [IsoXmlTag("Rct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReceipt3? Receipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt3? Receipt { get; init; } 
    #else
    public PaymentReceipt3? Receipt { get; set; } 
    #endif
    
    
    #nullable disable
    
}
