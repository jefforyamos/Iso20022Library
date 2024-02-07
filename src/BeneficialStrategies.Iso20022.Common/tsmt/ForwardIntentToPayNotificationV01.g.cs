﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForwardIntentToPayNotificationV01.  ISO2002 ID# _o9cY-NE8Ed-BzquC8wXy7w_-293305328.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.tsmt.ForwardIntentToPayNotificationV01>;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.045.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected.
/// </summary>
[Serializable]
[Description(@"Scope|The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected.")]
public partial record ForwardIntentToPayNotificationV01 : IOuterRecord<ForwardIntentToPayNotificationV01,ForwardIntentToPayNotificationV01Document>
    ,IIsoXmlSerilizable<ForwardIntentToPayNotificationV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.045.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FwdInttToPayNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ForwardIntentToPayNotificationV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_o9cY-dE8Ed-BzquC8wXy7w_-1911719018")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_o9cY-tE8Ed-BzquC8wXy7w_-1913566608")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_o9cY-9E8Ed-BzquC8wXy7w_-1903407456")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    [Required]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_o9mJ8NE8Ed-BzquC8wXy7w_-1902481395")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required TransactionStatus4 TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the financial institutions involved in this transaction.
    /// </summary>
    [IsoId("_o9mJ8dE8Ed-BzquC8wXy7w_89089762")]
    [Description(@"Reference to the transaction for the financial institutions involved in this transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_o9mJ8tE8Ed-BzquC8wXy7w_97401247")]
    [Description(@"The financial institution of the buyer, uniquely identified by its BIC.")]
    [DataMember(Name="BuyrBk")]
    [XmlElement(ElementName="BuyrBk")]
    [Required]
    public required BICIdentification1 BuyerBank { get; init; }
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_o9mJ89E8Ed-BzquC8wXy7w_99248879")]
    [Description(@"The financial institution of the seller, uniquely identified by its BIC.")]
    [DataMember(Name="SellrBk")]
    [XmlElement(ElementName="SellrBk")]
    [Required]
    public required BICIdentification1 SellerBank { get; init; }
    
    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_o9mJ9NE8Ed-BzquC8wXy7w_2032766900")]
    [Description(@"Provides the details of the intention to pay.")]
    [DataMember(Name="InttToPay")]
    [XmlElement(ElementName="InttToPay")]
    [Required]
    public required IntentToPay1 IntentToPay { get; init; }
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_o9mJ9dE8Ed-BzquC8wXy7w_112177835")]
    [Description(@"Next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForwardIntentToPayNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForwardIntentToPayNotificationV01Document ToDocument()
    {
        return new ForwardIntentToPayNotificationV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FwdInttToPayNtfctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "NtfctnId", xmlNamespace );
        NotificationIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EstblishdBaselnId", xmlNamespace );
        EstablishedBaselineIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxSts", xmlNamespace );
        TransactionStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UsrTxRef", xmlNamespace );
        UserTransactionReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "BuyrBk", xmlNamespace );
        BuyerBank.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SellrBk", xmlNamespace );
        SellerBank.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InttToPay", xmlNamespace );
        IntentToPay.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RequestForAction is PendingActivity2 RequestForActionValue)
        {
            writer.WriteStartElement(null, "ReqForActn", xmlNamespace );
            RequestForActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForwardIntentToPayNotificationV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForwardIntentToPayNotificationV01"/>.
/// </summary>
[Serializable]
public partial record ForwardIntentToPayNotificationV01Document : IOuterDocument<ForwardIntentToPayNotificationV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForwardIntentToPayNotificationV01"/> is required.
    /// </summary>
    [DataMember(Name=ForwardIntentToPayNotificationV01.XmlTag)]
    public required ForwardIntentToPayNotificationV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ForwardIntentToPayNotificationV01.XmlTag);
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
