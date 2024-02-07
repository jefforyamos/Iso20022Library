﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MisMatchRejectionV02.  ISO2002 ID# _scq46NE8Ed-BzquC8wXy7w_1101360695.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.tsmt.MisMatchRejectionV02>;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.022.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MisMatchRejection message is sent by the party requested to accept or reject data set mis-matches to the matching application.
/// This message is used to reject mis-matches between data sets and the related baseline.
/// Usage
/// The MisMatchRejection message can be sent by the party requested to accept or reject data set mis-match to inform that it rejects the data set(s).
/// The message can be sent in response to a DataSetMatchReport message conveying mis-matches.
/// The information about the rejection of the mis-matched data sets will be forwarded by the matching application to the submitter of the data sets by a MisMatchRejectionNotification message.
/// The acceptance of mis-matched data sets can be achieved by sending a MisMatchAcceptance message.
/// </summary>
[Serializable]
[Description(@"Scope|The MisMatchRejection message is sent by the party requested to accept or reject data set mis-matches to the matching application.|This message is used to reject mis-matches between data sets and the related baseline.|Usage|The MisMatchRejection message can be sent by the party requested to accept or reject data set mis-match to inform that it rejects the data set(s).|The message can be sent in response to a DataSetMatchReport message conveying mis-matches.|The information about the rejection of the mis-matched data sets will be forwarded by the matching application to the submitter of the data sets by a MisMatchRejectionNotification message.|The acceptance of mis-matched data sets can be achieved by sending a MisMatchAcceptance message.")]
public partial record MisMatchRejectionV02 : IOuterRecord<MisMatchRejectionV02,MisMatchRejectionV02Document>
    ,IIsoXmlSerilizable<MisMatchRejectionV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.022.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MisMtchRjctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MisMatchRejectionV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_scq46dE8Ed-BzquC8wXy7w_1101360850")]
    [Description(@"Identifies the rejection message.")]
    [DataMember(Name="RjctnId")]
    [XmlElement(ElementName="RjctnId")]
    [Required]
    public required MessageIdentification1 RejectionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_scq46tE8Ed-BzquC8wXy7w_1101360765")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_scq469E8Ed-BzquC8wXy7w_1101360819")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Reference to the identification of the report that contained the difference.
    /// </summary>
    [IsoId("_sc0C0NE8Ed-BzquC8wXy7w_1101360734")]
    [Description(@"Reference to the identification of the report that contained the difference.")]
    [DataMember(Name="DataSetMtchRptRef")]
    [XmlElement(ElementName="DataSetMtchRptRef")]
    [Required]
    public required MessageIdentification1 DataSetMatchReportReference { get; init; }
    
    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_sc0C0dE8Ed-BzquC8wXy7w_1101360788")]
    [Description(@"Reason why the user cannot accept the request.")]
    [DataMember(Name="RjctnRsn")]
    [XmlElement(ElementName="RjctnRsn")]
    [Required]
    public required RejectionReason1Choice_ RejectionReason { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MisMatchRejectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MisMatchRejectionV02Document ToDocument()
    {
        return new MisMatchRejectionV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MisMtchRjctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "RjctnId", xmlNamespace );
        RejectionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SubmitterTransactionReference is SimpleIdentificationInformation SubmitterTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "SubmitrTxRef", xmlNamespace );
            SubmitterTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DataSetMtchRptRef", xmlNamespace );
        DataSetMatchReportReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RjctnRsn", xmlNamespace );
        RejectionReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MisMatchRejectionV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MisMatchRejectionV02"/>.
/// </summary>
[Serializable]
public partial record MisMatchRejectionV02Document : IOuterDocument<MisMatchRejectionV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MisMatchRejectionV02"/> is required.
    /// </summary>
    [DataMember(Name=MisMatchRejectionV02.XmlTag)]
    public required MisMatchRejectionV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MisMatchRejectionV02.XmlTag);
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
