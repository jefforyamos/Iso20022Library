﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesNonTradingDayReport1.  ISO2002 ID# _zms14Gw0EeWD9e8QDBgUOw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details the non-working days of an entity.
/// </summary>
public partial record SecuritiesNonTradingDayReport1
     : IIsoXmlSerilizable<SecuritiesNonTradingDayReport1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific venue this relates to - operating MIC, segment MIC, NCA
    /// </summary>
    public required TradingVenueIdentification1Choice_ Identification { get; init; } 
    /// <summary>
    /// Provides the non working days of the identified venue. Details on why it is a non working day are also captured.
    /// </summary>
    public SecuritiesNonTradingDay1? NonWorkingDay { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _BieD0GxOEeWD9e8QDBgUOw
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize NonWorkingDay, multiplicity Unknown
    }
    public static SecuritiesNonTradingDayReport1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
