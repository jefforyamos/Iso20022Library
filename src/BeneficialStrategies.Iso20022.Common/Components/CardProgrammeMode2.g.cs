﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardProgrammeMode2.  ISO2002 ID# _2fS94-kOEemeDPHh-U9b6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme or brand of the card for the transaction.
/// </summary>
public partial record CardProgrammeMode2
     : IIsoXmlSerilizable<CardProgrammeMode2>
{
    #nullable enable
    
    /// <summary>
    /// Type of card programme or brand.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Identification of the card programme or brand.
    /// </summary>
    public IsoMax35Text? Identification { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _2fS95OkOEemeDPHh-U9b6w
    
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
        if (Type is IsoMax35Text TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize Identification, multiplicity Unknown
    }
    public static CardProgrammeMode2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
