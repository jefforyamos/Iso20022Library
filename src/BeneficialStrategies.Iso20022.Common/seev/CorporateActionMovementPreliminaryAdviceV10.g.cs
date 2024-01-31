﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementPreliminaryAdviceV10.  ISO2002 ID# _BBQdCbT-EeiTob_PrFFUxA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.035.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionMovementPreliminaryAdviceV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_BBQdF7T-EeiTob_PrFFUxA")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_BBQdGbT-EeiTob_PrFFUxA")]
    [Description(@"General information about the movement preliminary advice document.")]
    [DataMember(Name="MvmntPrlimryAdvcGnlInf")]
    [XmlElement(ElementName="MvmntPrlimryAdvcGnlInf")]
    [Required]
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_BBQdG7T-EeiTob_PrFFUxA")]
    [Description(@"Identification of a previously sent movement preliminary advice document.")]
    [DataMember(Name="PrvsMvmntPrlimryAdvcId")]
    [XmlElement(ElementName="PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_BBQdHbT-EeiTob_PrFFUxA")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    public DocumentIdentification31? NotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_BBQdH7T-EeiTob_PrFFUxA")]
    [Description(@"Identification of a previously sent movement confirmation document.")]
    [DataMember(Name="MvmntConfId")]
    [XmlElement(ElementName="MvmntConfId")]
    public DocumentIdentification31? MovementConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_BBQdIbT-EeiTob_PrFFUxA")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_BBQdI7T-EeiTob_PrFFUxA")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification32? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_BBQdJbT-EeiTob_PrFFUxA")]
    [Description(@"Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference3? EventsLinkage { get; init; }
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_BBQdJ7T-EeiTob_PrFFUxA")]
    [Description(@"Reason for the reversal.")]
    [DataMember(Name="RvslRsn")]
    [XmlElement(ElementName="RvslRsn")]
    public CorporateActionReversalReason3? ReversalReason { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BBQdKbT-EeiTob_PrFFUxA")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation128 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_BBQdK7T-EeiTob_PrFFUxA")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required IAccountIdentification41Choice AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_BBQdLbT-EeiTob_PrFFUxA")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction42? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_BBQdL7T-EeiTob_PrFFUxA")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntDtls")]
    public CorporateActionOption153? CorporateActionMovementDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_BBQdMbT-EeiTob_PrFFUxA")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative28? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_BBQdM7T-EeiTob_PrFFUxA")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public IPartyIdentification129Choice? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_BBQdNbT-EeiTob_PrFFUxA")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public IPartyIdentification120Choice? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_BBQdN7T-EeiTob_PrFFUxA")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public IPartyIdentification120Choice? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_BBQdObT-EeiTob_PrFFUxA")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public IPartyIdentification120Choice? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_BBQdO7T-EeiTob_PrFFUxA")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public IPartyIdentification120Choice? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_BBQdPbT-EeiTob_PrFFUxA")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public IPartyIdentification120Choice? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_BBQdP7T-EeiTob_PrFFUxA")]
    [Description(@"A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public IPartyIdentification120Choice? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_BBQdQbT-EeiTob_PrFFUxA")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public IPartyIdentification120Choice? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_BBQdQ7T-EeiTob_PrFFUxA")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public IPartyIdentification120Choice? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BBQdRbT-EeiTob_PrFFUxA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_5W0VQ7XLEeiTob_PrFFUxA")]
    [Description(@"Issuer of the financial instrument.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    public IPartyIdentification129Choice? Issuer { get; init; }
    
    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_5W0VRLXLEeiTob_PrFFUxA")]
    [Description(@"Party making the offer and which is different from the issuing company.")]
    [DataMember(Name="Offerr")]
    [XmlElement(ElementName="Offerr")]
    public IPartyIdentification129Choice? Offeror { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_5W0VRbXLEeiTob_PrFFUxA")]
    [Description(@"A trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.")]
    [DataMember(Name="TrfAgt")]
    [XmlElement(ElementName="TrfAgt")]
    public IPartyIdentification129Choice? TransferAgent { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementPreliminaryAdviceV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceV10Document ToDocument()
    {
        return new CorporateActionMovementPreliminaryAdviceV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementPreliminaryAdviceV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionMovementPreliminaryAdviceV10Document : IOuterDocument<CorporateActionMovementPreliminaryAdviceV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementPreliminaryAdviceV10"/> is required.
    /// </summary>
    public required CorporateActionMovementPreliminaryAdviceV10 Message { get; init; }
}
