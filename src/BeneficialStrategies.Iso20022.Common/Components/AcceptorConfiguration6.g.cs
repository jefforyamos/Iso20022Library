﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfiguration6.  ISO2002 ID# _iXLKgbAHEeah1_v59tW6Rg.
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
public partial record AcceptorConfiguration6
     : IIsoXmlSerilizable<AcceptorConfiguration6>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    public TerminalManagementDataSet20? DataSet { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _iirP47AHEeah1_v59tW6Rg
    
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
        // Not sure how to serialize DataSet, multiplicity Unknown
    }
    public static AcceptorConfiguration6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
