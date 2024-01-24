﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAElectionAmendmentRequestV01.  ISO2002 ID# _TNAo_tEwEd-BzquC8wXy7w_1507742806.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to request the authorisation of an amendment of a previously sent Agent Corporate Action Election Advice message.
/// Usage
/// This message is used to request the amendment of a previously sent Agent Corporate Action Election Advice message.
/// Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.
/// This message is used when the terms and conditions of the corporate action event allow amendments.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to request the authorisation of an amendment of a previously sent Agent Corporate Action Election Advice message.|Usage|This message is used to request the amendment of a previously sent Agent Corporate Action Election Advice message.|Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.|This message is used when the terms and conditions of the corporate action event allow amendments.")]
public partial record AgentCAElectionAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnAmdmntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the request.
    /// </summary>
    [IsoId("_TNAo_9EwEd-BzquC8wXy7w_32107139")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the request.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Identification of the linked Agent CA Election Advice for which an amendment is requested.
    /// </summary>
    [IsoId("_TNApANEwEd-BzquC8wXy7w_61660705")]
    [Description(@"Identification of the linked Agent CA Election Advice for which an amendment is requested.")]
    [DataMember(Name="AgtCAElctnAdvcId")]
    [XmlElement(ElementName="AgtCAElctnAdvcId")]
    [Required]
    public required SomeAgentCAElectionAdviceIdentificationRecord AgentCAElectionAdviceIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNApAdEwEd-BzquC8wXy7w_-1916344559")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides information about the account.
    /// </summary>
    [IsoId("_TNJy4NEwEd-BzquC8wXy7w_-148394854")]
    [Description(@"Provides information about the account.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Provides information about the original election to be amended.
    /// </summary>
    [IsoId("_TNJy4dEwEd-BzquC8wXy7w_915892144")]
    [Description(@"Provides information about the original election to be amended.")]
    [DataMember(Name="OrgnlElctnDtls")]
    [XmlElement(ElementName="OrgnlElctnDtls")]
    [Required]
    public required SomeOriginalElectionDetailsRecord OriginalElectionDetails { get; init; }
    
    /// <summary>
    /// Provides information about the amendments to the election.
    /// </summary>
    [IsoId("_TNJy4tEwEd-BzquC8wXy7w_934364367")]
    [Description(@"Provides information about the amendments to the election.")]
    [DataMember(Name="AmddElctnDtls")]
    [XmlElement(ElementName="AmddElctnDtls")]
    [Required]
    public required SomeAmendedElectionDetailsRecord AmendedElectionDetails { get; init; }
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TNJy49EwEd-BzquC8wXy7w_459673267")]
    [Description(@"Contact responsible for the transaction identified in the message.")]
    [DataMember(Name="CtctDtls")]
    [XmlElement(ElementName="CtctDtls")]
    public SomeContactDetailsRecord? ContactDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCAElectionAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAElectionAmendmentRequestV01Document ToDocument()
    {
        return new AgentCAElectionAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCAElectionAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCAElectionAmendmentRequestV01Document : IOuterDocument<AgentCAElectionAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCAElectionAmendmentRequestV01"/> is required.
    /// </summary>
    public required AgentCAElectionAmendmentRequestV01 Message { get; init; }
}
