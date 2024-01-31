﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for LiquidityCreditTransferV05.  ISO2002 ID# _jwlbrxbvEeiyVv5j1vf1VQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// The LiquidityCreditTransfer message is sent by a member to the transaction administrator.
/// It is used to request a transfer of funds between two accounts belonging to the same member or the same group of accounts, and being held at the transaction administrator.
/// Usage
/// At any time during the operating hours of the system, and to perform the appropriate liquidity management, the member can request the transaction administrator to execute the transfer of funds between two accounts that the transaction administrator maintains for the member. For instance, this may be an action resulting from a Get/Return Account pair of messages.
/// The LiquidityCreditTransfer message can be used when the transactions to/from the member are unbalanced in value for the business day, or to unlock pending transactions at the end of day.
/// The member can request the transfer by identifying the accounts stored at the transaction administrator:
/// - If the accounts involved in the requested transfer are known without doubt to the transaction administrator, it is possible to indicate only the type of the account to be credited.
/// - If, on the contrary, more clarity is desired, it is possible to identify the accounts from and to which the funds should be transferred.
/// Note that transfers are processed only when the balance in the account to be debited is sufficient to pass the liquidity transfer instruction and remain positive. Based on the criteria received within the LiquidityCreditTransfer message, the transaction administrator will execute or reject the requested transfer.
/// In principle, the transaction administrator may send a Receipt message as a reply to the liquidity transfer request. To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The LiquidityCreditTransfer message is sent by a member to the transaction administrator.|It is used to request a transfer of funds between two accounts belonging to the same member or the same group of accounts, and being held at the transaction administrator.|Usage|At any time during the operating hours of the system, and to perform the appropriate liquidity management, the member can request the transaction administrator to execute the transfer of funds between two accounts that the transaction administrator maintains for the member. For instance, this may be an action resulting from a Get/Return Account pair of messages.|The LiquidityCreditTransfer message can be used when the transactions to/from the member are unbalanced in value for the business day, or to unlock pending transactions at the end of day.|The member can request the transfer by identifying the accounts stored at the transaction administrator:|- If the accounts involved in the requested transfer are known without doubt to the transaction administrator, it is possible to indicate only the type of the account to be credited.|- If, on the contrary, more clarity is desired, it is possible to identify the accounts from and to which the funds should be transferred.|Note that transfers are processed only when the balance in the account to be debited is sufficient to pass the liquidity transfer instruction and remain positive. Based on the criteria received within the LiquidityCreditTransfer message, the transaction administrator will execute or reject the requested transfer.|In principle, the transaction administrator may send a Receipt message as a reply to the liquidity transfer request. To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.")]
public partial record LiquidityCreditTransferV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "LqdtyCdtTrf";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbsRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Details of the liquidity credit transfer.
    /// </summary>
    [IsoId("_jwlbsxbvEeiyVv5j1vf1VQ")]
    [Description(@"Details of the liquidity credit transfer.")]
    [DataMember(Name="LqdtyCdtTrf")]
    [XmlElement(ElementName="LqdtyCdtTrf")]
    [Required]
    public required LiquidityCreditTransfer2 LiquidityCreditTransfer { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbtRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="LiquidityCreditTransferV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public LiquidityCreditTransferV05Document ToDocument()
    {
        return new LiquidityCreditTransferV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="LiquidityCreditTransferV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record LiquidityCreditTransferV05Document : IOuterDocument<LiquidityCreditTransferV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.050.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="LiquidityCreditTransferV05"/> is required.
    /// </summary>
    public required LiquidityCreditTransferV05 Message { get; init; }
}
