﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfiguration5.  ISO2002 ID# _aLzn8Y32EeWRwov1g9WL_A.
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
public partial record AcceptorConfiguration5
     : IIsoXmlSerilizable<AcceptorConfiguration5>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    public TerminalManagementDataSet19? DataSet { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _aX4VFY32EeWRwov1g9WL_A
    
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
    public static AcceptorConfiguration5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
