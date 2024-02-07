﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NetReportData2.  ISO2002 ID# _CWAzsQN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the meta data associated with a net report.
/// </summary>
public partial record NetReportData2
     : IIsoXmlSerilizable<NetReportData2>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the net report was generated.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Provides the cut off time that has been passed, resulting in the generation of the net report.
    /// </summary>
    public required IsoISOTime NettingCutOffTime { get; init; } 
    /// <summary>
    /// Specifies the value date on which the net report was generated.
    /// </summary>
    public required IsoISODate ReportDate { get; init; } 
    /// <summary>
    /// Specifies the value date of the trades used in the generation of the net report.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Specifies the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    public IsoMax35Text? ReportType { get; init; } 
    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    public PartyIdentification242Choice_? NetReportServicer { get; init; } 
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    public IsoMax35Text? NetServiceType { get; init; } 
    /// <summary>
    /// Page number of the message (within the net report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    public Pagination1? MessagePagination { get; init; } 
    
    #nullable disable
    
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NetgCutOffTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISOTime(NettingCutOffTime)); // data type ISOTime System.TimeOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ReportDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (ReportType is IsoMax35Text ReportTypeValue)
        {
            writer.WriteStartElement(null, "RptTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReportTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (NetReportServicer is PartyIdentification242Choice_ NetReportServicerValue)
        {
            writer.WriteStartElement(null, "NetRptSvcr", xmlNamespace );
            NetReportServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetServiceType is IsoMax35Text NetServiceTypeValue)
        {
            writer.WriteStartElement(null, "NetSvcTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NetServiceTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MessagePagination is Pagination1 MessagePaginationValue)
        {
            writer.WriteStartElement(null, "MsgPgntn", xmlNamespace );
            MessagePaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static NetReportData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
