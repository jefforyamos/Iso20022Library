﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CustomerIdentification1.  ISO2002 ID# _cgxhY0yuEeGcV5yVhSZuNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a customer identification as the search criteria for the financial institution to do the investigation.
/// </summary>
public partial record CustomerIdentification1
     : IIsoXmlSerilizable<CustomerIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the customer for the investigation.
    /// </summary>
    public required PartyIdentification43 Party { get; init; } 
    /// <summary>
    /// Specifies the authority request related to the identified investigation party.
    /// </summary>
    public AuthorityInvestigation2? AuthorityRequest { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _jP3PoUyuEeGcV5yVhSZuNw
    
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
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize AuthorityRequest, multiplicity Unknown
    }
    public static CustomerIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
