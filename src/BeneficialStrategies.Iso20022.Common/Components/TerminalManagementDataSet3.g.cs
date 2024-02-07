﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet3.  ISO2002 ID# _K9f5En1DEeCF8NjrBemJWQ_137212968.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
public partial record TerminalManagementDataSet3
     : IIsoXmlSerilizable<TerminalManagementDataSet3>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    public required DataSetIdentification2 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    public required AcceptorConfigurationContent1 Content { get; init; } 
    
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
    public static TerminalManagementDataSet3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
