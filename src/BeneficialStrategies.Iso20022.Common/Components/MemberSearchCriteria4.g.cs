﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberSearchCriteria4.  ISO2002 ID# _i_EmMXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a member.
/// </summary>
public partial record MemberSearchCriteria4
     : IIsoXmlSerilizable<MemberSearchCriteria4>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public MemberIdentification3Choice_? Identification { get; init; } 
    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    public SystemMemberType1Choice_? Type { get; init; } 
    /// <summary>
    /// Status of a member in a system, such as enabled or deleted.
    /// </summary>
    public SystemMemberStatus1Choice_? Status { get; init; } 
    
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
        if (Identification is MemberIdentification3Choice_ IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Type is SystemMemberType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Status is SystemMemberStatus1Choice_ StatusValue)
        {
            writer.WriteStartElement(null, "Sts", xmlNamespace );
            StatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MemberSearchCriteria4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
