﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet28.  ISO2002 ID# _-JJEAfGQEeibbsF9Yi4diw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the status report of a point of interaction (POI).
/// </summary>
public partial record TerminalManagementDataSet28
     : IIsoXmlSerilizable<TerminalManagementDataSet28>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    public required DataSetIdentification7 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Content of the status report.
    /// </summary>
    public required StatusReportContent8 Content { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SequenceCounter is IsoMax9NumericText SequenceCounterValue)
        {
            writer.WriteStartElement(null, "SeqCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax9NumericText(SequenceCounterValue)); // data type Max9NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Cntt", xmlNamespace );
        Content.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TerminalManagementDataSet28 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
