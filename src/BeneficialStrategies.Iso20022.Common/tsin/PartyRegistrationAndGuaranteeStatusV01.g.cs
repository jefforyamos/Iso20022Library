﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyRegistrationAndGuaranteeStatusV01.  ISO2002 ID# _OTgzNDcw-AOSNFX-8224506.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsin;


/// <summary>
/// This record is an implementation of the tsin.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message PartyRegistrationAndGuaranteeStatus is either sent by a factoring service to a financing client to indicate the status of a factoring service agreement or from a guarantee issuer to a factoring client or a factoring service to indicate the guarantee covering a requested factoring service agreement. The message can also be sent to an interested party.
/// The factoring service or guarantee issuer may include references to a corresponding PartyRegistrationAndGuaranteeRequest message or other related messages and may include referenced data.
/// The message contains information about other parties to be notified about the financial service agreement or the guarantee and whether these parties are required to acknowledge the agreement.
/// The message contains information returned by the financial institution indicating acceptance or rejection of the trade partner; a positive response is necessary before being able to assign financial items concerning the trade party.
/// This message contains identifications of cash accounts to enable payer and payee to treat the transferred payment obligations.
/// The message can carry digital signatures if required by context.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The message PartyRegistrationAndGuaranteeStatus is either sent by a factoring service to a financing client to indicate the status of a factoring service agreement or from a guarantee issuer to a factoring client or a factoring service to indicate the guarantee covering a requested factoring service agreement. The message can also be sent to an interested party.|The factoring service or guarantee issuer may include references to a corresponding PartyRegistrationAndGuaranteeRequest message or other related messages and may include referenced data.|The message contains information about other parties to be notified about the financial service agreement or the guarantee and whether these parties are required to acknowledge the agreement.|The message contains information returned by the financial institution indicating acceptance or rejection of the trade partner; a positive response is necessary before being able to assign financial items concerning the trade party.|This message contains identifications of cash accounts to enable payer and payee to treat the transferred payment obligations.|The message can carry digital signatures if required by context.")]
public partial record PartyRegistrationAndGuaranteeStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntSts";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics that unambiguously identify the status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDcx-AOSNFX-8224506")]
    [Description(@"Set of characteristics that unambiguously identify the status, common parameters, documents and identifications.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required BusinessLetter1 Header { get; init; }
    
    /// <summary>
    /// List of agreements.
    /// </summary>
    [IsoId("_OTgzNDcy-AOSNFX-8224506")]
    [Description(@"List of agreements.")]
    [DataMember(Name="AgrmtList")]
    [XmlElement(ElementName="AgrmtList")]
    [Required]
    public required FinancingAgreementList1 AgreementList { get; init; }
    
    /// <summary>
    /// Number of agreement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDcz-AOSNFX-8224506")]
    [Description(@"Number of agreement lists as control value.")]
    [DataMember(Name="AgrmtCnt")]
    [XmlElement(ElementName="AgrmtCnt")]
    public IsoMax15NumericText? AgreementCount { get; init; }
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDc0-AOSNFX-8224506")]
    [Description(@"Total number of individual items in all lists.")]
    [DataMember(Name="ItmCnt")]
    [XmlElement(ElementName="ItmCnt")]
    public IsoMax15NumericText? ItemCount { get; init; }
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDc1-AOSNFX-8224506")]
    [Description(@"Total of all individual amounts included in all lists, irrespective of currencies or direction.")]
    [DataMember(Name="CtrlSum")]
    [XmlElement(ElementName="CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDc2-AOSNFX-8224506")]
    [Description(@"Referenced or related business message.")]
    [DataMember(Name="AttchdMsg")]
    [XmlElement(ElementName="AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyRegistrationAndGuaranteeStatusV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyRegistrationAndGuaranteeStatusV01Document ToDocument()
    {
        return new PartyRegistrationAndGuaranteeStatusV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyRegistrationAndGuaranteeStatusV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyRegistrationAndGuaranteeStatusV01Document : IOuterDocument<PartyRegistrationAndGuaranteeStatusV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyRegistrationAndGuaranteeStatusV01"/> is required.
    /// </summary>
    public required PartyRegistrationAndGuaranteeStatusV01 Message { get; init; }
}
