﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraPositionMovementPostingReportV08.  ISO2002 ID# __5H8IemfEemm4qhb2yFPOw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.semt.IntraPositionMovementPostingReportV08>;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// This record is an implementation of the semt.016.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IntraPositionMovementPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner. 
/// 
/// |The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participant
/// - an agent (sub-custodian) acting on behalf of its global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage|:
/// The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|The IntraPositionMovementPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner. |||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participant|- an agent (sub-custodian) acting on behalf of its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|:|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header.")]
public partial record IntraPositionMovementPostingReportV08 : IOuterRecord<IntraPositionMovementPostingReportV08,IntraPositionMovementPostingReportV08Document>
    ,IIsoXmlSerilizable<IntraPositionMovementPostingReportV08>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.016.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntPstngRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IntraPositionMovementPostingReportV08Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("__5H8KemfEemm4qhb2yFPOw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// General information related to the report.
    /// </summary>
    [IsoId("__5H8K-mfEemm4qhb2yFPOw")]
    [Description(@"General information related to the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement80 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("__5H8LemfEemm4qhb2yFPOw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("__5H8L-mfEemm4qhb2yFPOw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("__5H8MemfEemm4qhb2yFPOw")]
    [Description(@"Reporting per financial instrument.")]
    [DataMember(Name="FinInstrm")]
    [XmlElement(ElementName="FinInstrm")]
    public FinancialInstrumentDetails34? FinancialInstrument { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraPositionMovementPostingReportV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraPositionMovementPostingReportV08Document ToDocument()
    {
        return new IntraPositionMovementPostingReportV08Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("IntraPosMvmntPstngRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Pgntn", xmlNamespace );
        Pagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StmtGnlDtls", xmlNamespace );
        StatementGeneralDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification127Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrument is FinancialInstrumentDetails34 FinancialInstrumentValue)
        {
            writer.WriteStartElement(null, "FinInstrm", xmlNamespace );
            FinancialInstrumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraPositionMovementPostingReportV08 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraPositionMovementPostingReportV08"/>.
/// </summary>
[Serializable]
public partial record IntraPositionMovementPostingReportV08Document : IOuterDocument<IntraPositionMovementPostingReportV08>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.016.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraPositionMovementPostingReportV08"/> is required.
    /// </summary>
    [DataMember(Name=IntraPositionMovementPostingReportV08.XmlTag)]
    public required IntraPositionMovementPostingReportV08 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(IntraPositionMovementPostingReportV08.XmlTag);
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
