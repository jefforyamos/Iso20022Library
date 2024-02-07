﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation8.  ISO2002 ID# _xIm7YUEJEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
public partial record UpdatedAdditionalInformation8
     : IIsoXmlSerilizable<UpdatedAdditionalInformation8>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    public IsoMax140Text? UpdateDescription { get; init; } 
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    public IsoISODate? UpdateDate { get; init; } 
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    public IsoMax8000Text? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _xWSyGUEJEeWVgfuHGaKtRQ
    
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
        if (UpdateDescription is IsoMax140Text UpdateDescriptionValue)
        {
            writer.WriteStartElement(null, "UpdDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(UpdateDescriptionValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (UpdateDate is IsoISODate UpdateDateValue)
        {
            writer.WriteStartElement(null, "UpdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(UpdateDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        // Not sure how to serialize AdditionalInformation, multiplicity Unknown
    }
    public static UpdatedAdditionalInformation8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
