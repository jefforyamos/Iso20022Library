﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralProposalResponseV04.  ISO2002 ID# _fkI0oYFrEeWtPe6Crjmeug.
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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.008.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralProposalResponse message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to either accept or reject the collateral which has been proposed for the margin call. This message applies to both initial and counter proposals. If the collateral proposal is rejected then a new collateral proposal must be made.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The CollateralProposalResponse message can be sent in response to a previously received CollateralProposal message in order to accept or reject the collateral that has been proposed to cover the margin call.
/// </summary>
[Description(@"Scope|The CollateralProposalResponse message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to either accept or reject the collateral which has been proposed for the margin call. This message applies to both initial and counter proposals. If the collateral proposal is rejected then a new collateral proposal must be made.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralProposalResponse message can be sent in response to a previously received CollateralProposal message in order to accept or reject the collateral that has been proposed to cover the margin call.")]
[IsoId("_fkI0oYFrEeWtPe6Crjmeug")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral Proposal Response V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposalResponseV04 : IOuterRecord<CollateralProposalResponseV04,CollateralProposalResponseV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.008.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollPrpslRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CollateralProposalResponseV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposalResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposalResponseV04( System.String reqTransactionIdentification,Obligation4 reqObligation,CollateralProposalResponse2Choice_ reqProposalResponse )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        ProposalResponse = reqProposalResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_fkI0o4FrEeWtPe6Crjmeug")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_fkI0pYFrEeWtPe6Crjmeug")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Obligation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation4 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Obligation4 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation4 Obligation { get; init; } 
    #else
    public Obligation4 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Details the response to the collateral which has been proposed for the margin call. The proposed collateral can be accepted or rejected.
    /// </summary>
    [IsoId("_fkI0p4FrEeWtPe6Crjmeug")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proposal Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponse2Choice_ ProposalResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CollateralProposalResponse2Choice_ ProposalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponse2Choice_ ProposalResponse { get; init; } 
    #else
    public CollateralProposalResponse2Choice_ ProposalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_fkI0qYFrEeWtPe6Crjmeug")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralProposalResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralProposalResponseV04Document ToDocument()
    {
        return new CollateralProposalResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralProposalResponseV04"/>.
/// </summary>
[Serializable]
public partial record CollateralProposalResponseV04Document : IOuterDocument<CollateralProposalResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralProposalResponseV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponseV04 Message { get; init; }
    #else
    public CollateralProposalResponseV04 Message { get; init; }
    #endif
}
