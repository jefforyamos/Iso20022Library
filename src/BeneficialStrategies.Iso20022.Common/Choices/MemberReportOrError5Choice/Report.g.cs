﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _jmCfkXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError5Choice;

/// <summary>
/// Provides the details on the requested member.
/// </summary>
public partial record Report : MemberReportOrError5Choice_
     , IIsoXmlSerilizable<Report>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    public required MemberReportOrError6Choice_ MemberOrError { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MmbId", xmlNamespace );
        MemberIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MmbOrErr", xmlNamespace );
        MemberOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Report Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
