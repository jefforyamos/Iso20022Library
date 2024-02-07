﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationDataSet2.  ISO2002 ID# _dldCAS1sEeuZtpnZJ4v-5Q.
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
public partial record AcceptorConfigurationDataSet2
     : IIsoXmlSerilizable<AcceptorConfigurationDataSet2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    public required DataSetIdentification8 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    public IsoTrueFalseIndicator? LastSequence { get; init; } 
    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    public GenericIdentification176? POIIdentification { get; init; } 
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    public PartyType15Code? ConfigurationScope { get; init; } 
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    public required AcceptorConfigurationContent10 Content { get; init; } 
    
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
        if (LastSequence is IsoTrueFalseIndicator LastSequenceValue)
        {
            writer.WriteStartElement(null, "LastSeq", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(LastSequenceValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (POIIdentification is GenericIdentification176 POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            POIIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConfigurationScope is PartyType15Code ConfigurationScopeValue)
        {
            writer.WriteStartElement(null, "CfgtnScp", xmlNamespace );
            writer.WriteValue(ConfigurationScopeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Cntt", xmlNamespace );
        Content.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AcceptorConfigurationDataSet2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
