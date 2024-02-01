﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementConditionModificationStatusAdvice002V08.  ISO2002 ID# _D9PUbffXEeiNZp_PtLohLw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.031.002.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// A SecuritiesSettlementConditionsModificationRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|A SecuritiesSettlementConditionsModificationRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementConditionModificationStatusAdvice002V08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.031.002.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmCondModStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of the SecuritiesSettlementConditionsModificationRequest.
    /// </summary>
    [IsoId("_D9PUb_fXEeiNZp_PtLohLw")]
    [Description(@"Identification of the SecuritiesSettlementConditionsModificationRequest.")]
    [DataMember(Name="ReqRef")]
    [XmlElement(ElementName="ReqRef")]
    [Required]
    public required Identification16 RequestReference { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_D9PUcffXEeiNZp_PtLohLw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_D9PUc_fXEeiNZp_PtLohLw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SecuritiesAccount30? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Details of the request.
    /// </summary>
    [IsoId("_D9PUdffXEeiNZp_PtLohLw")]
    [Description(@"Details of the request.")]
    [DataMember(Name="ReqDtls")]
    [XmlElement(ElementName="ReqDtls")]
    public RequestDetails21? RequestDetails { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_D9PUd_fXEeiNZp_PtLohLw")]
    [Description(@"Provides details on the processing status of the request.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required ProcessingStatus58Choice_ ProcessingStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_D9PUeffXEeiNZp_PtLohLw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementConditionModificationStatusAdvice002V08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementConditionModificationStatusAdvice002V08Document ToDocument()
    {
        return new SecuritiesSettlementConditionModificationStatusAdvice002V08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementConditionModificationStatusAdvice002V08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementConditionModificationStatusAdvice002V08Document : IOuterDocument<SecuritiesSettlementConditionModificationStatusAdvice002V08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.031.002.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementConditionModificationStatusAdvice002V08"/> is required.
    /// </summary>
    public required SecuritiesSettlementConditionModificationStatusAdvice002V08 Message { get; init; }
}
