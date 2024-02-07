﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportingExemption1.  ISO2002 ID# _F10woBaIEe27wrM4RUjLog.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reporting exemption of a counterparty.
/// </summary>
public partial record ReportingExemption1
     : IIsoXmlSerilizable<ReportingExemption1>
{
    #nullable enable
    
    /// <summary>
    /// Code specifying exemption applicable to a counterparty.
    /// </summary>
    public required IsoMax4Text Reason { get; init; } 
    /// <summary>
    /// Textual description of applicable exemption.
    /// </summary>
    public IsoMax1000Text? Description { get; init; } 
    
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4Text(Reason)); // data type Max4Text System.String
        writer.WriteEndElement();
        if (Description is IsoMax1000Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1000Text(DescriptionValue)); // data type Max1000Text System.String
            writer.WriteEndElement();
        }
    }
    public static ReportingExemption1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
