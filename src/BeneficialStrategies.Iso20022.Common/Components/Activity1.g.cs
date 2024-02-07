﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Activity1.  ISO2002 ID# _RI5fxdp-Ed-ak6NoX_4Aeg_156972015.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message that is associated with the activity.
/// </summary>
public partial record Activity1
     : IIsoXmlSerilizable<Activity1>
{
    #nullable enable
    
    /// <summary>
    /// Name of the message associated with the activity.
    /// </summary>
    public required IsoMax70Text MessageName { get; init; } 
    /// <summary>
    /// Further information on a message associated with the activity.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax70Text(MessageName)); // data type Max70Text System.String
        writer.WriteEndElement();
        if (Description is IsoMax140Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(DescriptionValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static Activity1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
