﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingIssuanceAdviceV01.  ISO2002 ID# _9fkHg3ltEeG7BsjMvd1mEw_-135389308.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsrv;


/// <summary>
/// The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.")]
public partial record UndertakingIssuanceAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssncAdvc";
    
    #nullable enable
    /// <summary>
    /// Party advising the undertaking to the beneficiary or to another party.
    /// </summary>
    [IsoId("_HtBI0z1UEeKvwJ48Wu13ug")]
    [Description(@"Party advising the undertaking to the beneficiary or to another party.")]
    [DataMember(Name="AdvsgPty")]
    [XmlElement(ElementName="AdvsgPty")]
    [Required]
    public required PartyIdentification43 AdvisingParty { get; init; }
    
    /// <summary>
    /// Additional party that advises the undertaking.
    /// </summary>
    [IsoId("_WPnPkz1UEeKvwJ48Wu13ug")]
    [Description(@"Additional party that advises the undertaking.")]
    [DataMember(Name="ScndAdvsgPty")]
    [XmlElement(ElementName="ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; }
    
    /// <summary>
    /// Date on which the undertaking is advised.
    /// </summary>
    [IsoId("_bOgLdT1UEeKvwJ48Wu13ug")]
    [Description(@"Date on which the undertaking is advised.")]
    [DataMember(Name="DtOfAdvc")]
    [XmlElement(ElementName="DtOfAdvc")]
    [Required]
    public required IDateAndDateTimeChoice DateOfAdvice { get; init; }
    
    /// <summary>
    /// Details related to the advice of the issued undertaking.
    /// </summary>
    [IsoId("_9fkHhHltEeG7BsjMvd1mEw_-1882715655")]
    [Description(@"Details related to the advice of the issued undertaking.")]
    [DataMember(Name="UdrtkgIssncAdvcDtls")]
    [XmlElement(ElementName="UdrtkgIssncAdvcDtls")]
    [Required]
    public required UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; init; }
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_pgGLlRWxEeKtPMeuz5Qhfw")]
    [Description(@"Additional information specific to the bank-to-bank communication.")]
    [DataMember(Name="BkToBkInf")]
    [XmlElement(ElementName="BkToBkInf")]
    public required IReadOnlyCollection<IsoMax2000Text> BankToBankInformation { get; init; } = []; // Min=0, Max=5
    
    /// <summary>
    /// Digital signature of the undertaking advice.
    /// </summary>
    [IsoId("_9fkHhXltEeG7BsjMvd1mEw_1405552400")]
    [Description(@"Digital signature of the undertaking advice.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingIssuanceAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingIssuanceAdviceV01Document ToDocument()
    {
        return new UndertakingIssuanceAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingIssuanceAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingIssuanceAdviceV01Document : IOuterDocument<UndertakingIssuanceAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingIssuanceAdviceV01"/> is required.
    /// </summary>
    public required UndertakingIssuanceAdviceV01 Message { get; init; }
}
