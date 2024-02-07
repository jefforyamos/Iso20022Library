﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegationResponse5.  ISO2002 ID# _oIGS4S9EEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
public partial record MaintenanceDelegationResponse5
     : IIsoXmlSerilizable<MaintenanceDelegationResponse5>
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    public required GenericIdentification176 TMIdentification { get; init; } 
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    public MaintenanceDelegation12? DelegationResponse { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _oUmd1S9EEeu125Ip9zFcsQ
    
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
        writer.WriteStartElement(null, "TMId", xmlNamespace );
        TMIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MasterTMIdentification is GenericIdentification176 MasterTMIdentificationValue)
        {
            writer.WriteStartElement(null, "MstrTMId", xmlNamespace );
            MasterTMIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize DelegationResponse, multiplicity Unknown
    }
    public static MaintenanceDelegationResponse5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
