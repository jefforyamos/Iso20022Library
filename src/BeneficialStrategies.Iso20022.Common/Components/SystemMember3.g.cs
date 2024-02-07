﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemMember3.  ISO2002 ID# _htb_MXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about a system and about a member of a system.
/// </summary>
public partial record SystemMember3
     : IIsoXmlSerilizable<SystemMember3>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    
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
        if (SystemIdentification is SystemIdentification2Choice_ SystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SysId", xmlNamespace );
            SystemIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MmbId", xmlNamespace );
        MemberIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SystemMember3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
