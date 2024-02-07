﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingActivity1.  ISO2002 ID# _RJy3otp-Ed-ak6NoX_4Aeg_-149569640.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the event that require an action from one of the parties to the trade transaction.
/// </summary>
public partial record PendingActivity1
     : IIsoXmlSerilizable<PendingActivity1>
{
    #nullable enable
    
    /// <summary>
    /// Code which specifies the next course of action that the receiver of the message must take.
    /// </summary>
    public required Action1Code Type { get; init; } 
    /// <summary>
    /// Further information on the course of action that the receiver of the message must take.
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (Description is IsoMax140Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(DescriptionValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static PendingActivity1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
