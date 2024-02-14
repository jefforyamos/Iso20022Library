﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionModificationRequestV05.  ISO2002 ID# _cCQpsYvSEea5B-LIompvYg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.038.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an account owner to an account servicer. 
/// 
/// The account owner will generally be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an investment manager which has an account with a custodian acting as accounting and/or settlement agent.
/// 
/// It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.
/// 
/// Usage
/// The modification must only contain the data to be modified.
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|This message is sent by an account owner to an account servicer. ||The account owner will generally be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an investment manager which has an account with a custodian acting as accounting and/or settlement agent.||It is used to request the modification of non core business data (matching or non-matching) information in a pending or settled instruction. It can also be used for the enrichment of an incomplete transaction.||Usage|The modification must only contain the data to be modified.|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
[IsoId("_cCQpsYvSEea5B-LIompvYg")]
[DisplayName("Securities Settlement Transaction Modification Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionModificationRequestV05 : IOuterRecord<SecuritiesSettlementTransactionModificationRequestV05,SecuritiesSettlementTransactionModificationRequestV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.038.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxModReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionModificationRequestV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionModificationRequestV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestV05( TransactionDetails76 reqModifiedTransactionDetails )
    {
        ModifiedTransactionDetails = reqModifiedTransactionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the details of the transaction that is being modified.
    /// </summary>
    [IsoId("_cCQpuYvSEea5B-LIompvYg")]
    [DisplayName("Modified Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdTxDtls")]
    #endif
    [IsoXmlTag("ModfdTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionDetails76 ModifiedTransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionDetails76 ModifiedTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails76 ModifiedTransactionDetails { get; init; } 
    #else
    public TransactionDetails76 ModifiedTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of update requested.
    /// </summary>
    [IsoId("_cCQpu4vSEea5B-LIompvYg")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<UpdateType25Choice_> UpdateType { get; init; } = new ValueList<UpdateType25Choice_>(){};
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SecuritiesSettlementTransactionModificationRequestV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionModificationRequestV05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionModificationRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SecuritiesSettlementTransactionModificationRequestV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionModificationRequestV05Document : IOuterDocument<SecuritiesSettlementTransactionModificationRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.038.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SecuritiesSettlementTransactionModificationRequestV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesSettlementTransactionModificationRequestV05 Message { get; init; }
    #else
    public SecuritiesSettlementTransactionModificationRequestV05 Message { get; init; }
    #endif
}
