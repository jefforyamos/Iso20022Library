﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestRedirectionV02.  ISO2002 ID# _7HT_g242EeiU9cctagi5ow.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountSwitchRequestRedirectionV02>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.030.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.
/// </summary>
[Serializable]
[Description(@"The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.")]
public partial record AccountSwitchRequestRedirectionV02 : IOuterRecord<AccountSwitchRequestRedirectionV02,AccountSwitchRequestRedirectionV02Document>
    ,IIsoXmlSerilizable<AccountSwitchRequestRedirectionV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.030.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqRdrctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountSwitchRequestRedirectionV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HT_hW42EeiU9cctagi5ow")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_7HT_h242EeiU9cctagi5ow")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Account servicer holding the account to which the switch will be made for example the acquiring account servicer.
    /// </summary>
    [IsoId("_7HT_iW42EeiU9cctagi5ow")]
    [Description(@"Account servicer holding the account to which the switch will be made for example the acquiring account servicer.")]
    [DataMember(Name="NewAcct")]
    [XmlElement(ElementName="NewAcct")]
    [Required]
    public required CashAccount39 NewAccount { get; init; }
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_7HT_i242EeiU9cctagi5ow")]
    [Description(@"Account held at the old account servicer being switched to the new account servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required CashAccount39 OldAccount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HT_jW42EeiU9cctagi5ow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestRedirectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestRedirectionV02Document ToDocument()
    {
        return new AccountSwitchRequestRedirectionV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctSwtchReqRdrctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSwtchDtls", xmlNamespace );
        AccountSwitchDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NewAcct", xmlNamespace );
        NewAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OdAcct", xmlNamespace );
        OldAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountSwitchRequestRedirectionV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchRequestRedirectionV02"/>.
/// </summary>
[Serializable]
public partial record AccountSwitchRequestRedirectionV02Document : IOuterDocument<AccountSwitchRequestRedirectionV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.030.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestRedirectionV02"/> is required.
    /// </summary>
    [DataMember(Name=AccountSwitchRequestRedirectionV02.XmlTag)]
    public required AccountSwitchRequestRedirectionV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountSwitchRequestRedirectionV02.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
