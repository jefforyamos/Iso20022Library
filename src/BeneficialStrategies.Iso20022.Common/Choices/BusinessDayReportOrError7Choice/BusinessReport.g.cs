﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _wq9RgZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError7Choice;

/// <summary>
/// Reports either business day information or a business error.
/// </summary>
public partial record BusinessReport : BusinessDayReportOrError7Choice_
     , IIsoXmlSerilizable<BusinessReport>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular market infrastructure.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _wy9-A5lcEeeE1Ya-LgRsuQ
    /// <summary>
    /// Requested information on the system availability for a specific business day or business error when information has not been found.
    /// </summary>
    public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
    
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
        // Not sure how to serialize SystemIdentification, multiplicity Unknown
        writer.WriteStartElement(null, "BizDayOrErr", xmlNamespace );
        BusinessDayOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new BusinessReport Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
