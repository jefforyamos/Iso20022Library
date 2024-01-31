﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BuyInRegulatoryAdviceV01.  ISO2002 ID# _O1mdgZwQEeqtp-LOti013g.
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
/// This record is an implementation of the sese.041.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// |An account owner sends a BuyInRegulatoryAdvice to an account servicer to  notify the results of the buy-in transactions executed under CSDR regulatory regime.||
/// The account owner/servicer relationship may be:|- a central securities depository participant which has an account with a central securities depository.|It could also be, if agreed in a service level agreement:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|The ultimate receiving party at the end of the settlement chain is a central securities depository or interational central securities depository.||
/// 
/// Usage
/// |The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.||
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||An account owner sends a BuyInRegulatoryAdvice to an account servicer to  notify the results of the buy-in transactions executed under CSDR regulatory regime.|||The account owner/servicer relationship may be:|- a central securities depository participant which has an account with a central securities depository.|It could also be, if agreed in a service level agreement:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|The ultimate receiving party at the end of the settlement chain is a central securities depository or interational central securities depository.||||Usage||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.||")]
public partial record BuyInRegulatoryAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.041.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRgltryAdvc";
    
    #nullable enable
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_O1mdiZwQEeqtp-LOti013g")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }
    
    /// <summary>
    /// Account used in the original failing transaction.
    /// </summary>
    [IsoId("_O1mdi5wQEeqtp-LOti013g")]
    [Description(@"Account used in the original failing transaction.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Details of the buy-in.
    /// </summary>
    [IsoId("_O1mdjZwQEeqtp-LOti013g")]
    [Description(@"Details of the buy-in.")]
    [DataMember(Name="BuyInAttrbts")]
    [XmlElement(ElementName="BuyInAttrbts")]
    [Required]
    public required BuyInAdviceDetails1 BuyInAttributes { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_O1mdkZwQEeqtp-LOti013g")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BuyInRegulatoryAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BuyInRegulatoryAdviceV01Document ToDocument()
    {
        return new BuyInRegulatoryAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BuyInRegulatoryAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BuyInRegulatoryAdviceV01Document : IOuterDocument<BuyInRegulatoryAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.041.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BuyInRegulatoryAdviceV01"/> is required.
    /// </summary>
    public required BuyInRegulatoryAdviceV01 Message { get; init; }
}
