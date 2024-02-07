﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityRestriction3.  ISO2002 ID# _cIeP8Wf9Eembv_9KtOEw8g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions applicable to the security.
/// </summary>
public partial record SecurityRestriction3
     : IIsoXmlSerilizable<SecurityRestriction3>
{
    #nullable enable
    
    /// <summary>
    /// Period during which the restriction applies.
    /// </summary>
    public DateTimePeriod2? EffectivePeriod { get; init; } 
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; } 
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; } 
    /// <summary>
    /// Specifies whether the restriction to be applied is relevant for citizen, resident, country.
    /// </summary>
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; init; } 
    /// <summary>
    /// Type of investor that is allowed to hold the security.
    /// </summary>
    public InvestorType3Choice_? InvestorType { get; init; } 
    
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
        if (EffectivePeriod is DateTimePeriod2 EffectivePeriodValue)
        {
            writer.WriteStartElement(null, "FctvPrd", xmlNamespace );
            EffectivePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RestrictionType is SecurityRestrictionType2Choice_ RestrictionTypeValue)
        {
            writer.WriteStartElement(null, "RstrctnTp", xmlNamespace );
            RestrictionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalRestrictionType is LegalRestrictions5Choice_ LegalRestrictionTypeValue)
        {
            writer.WriteStartElement(null, "LglRstrctnTp", xmlNamespace );
            LegalRestrictionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestorRestrictionType is InvestorRestrictionType3Choice_ InvestorRestrictionTypeValue)
        {
            writer.WriteStartElement(null, "InvstrRstrctnTp", xmlNamespace );
            InvestorRestrictionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestorType is InvestorType3Choice_ InvestorTypeValue)
        {
            writer.WriteStartElement(null, "InvstrTp", xmlNamespace );
            InvestorTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecurityRestriction3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
