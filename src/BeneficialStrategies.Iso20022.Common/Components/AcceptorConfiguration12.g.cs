﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfiguration12.  ISO2002 ID# _PLZ6oXJ3Ee299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor configuration to be downloaded from the terminal management system.
/// </summary>
public partial record AcceptorConfiguration12
     : IIsoXmlSerilizable<AcceptorConfiguration12>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    public AcceptorConfigurationDataSet4? DataSet { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _PRyPdXJ3Ee299ZbWCkdR_w
    
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
        writer.WriteStartElement(null, "TermnlMgrId", xmlNamespace );
        TerminalManagerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (POIGroupIdentification is IsoMax35Text POIGroupIdentificationValue)
        {
            writer.WriteStartElement(null, "POIGrpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(POIGroupIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize DataSet, multiplicity Unknown
    }
    public static AcceptorConfiguration12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
