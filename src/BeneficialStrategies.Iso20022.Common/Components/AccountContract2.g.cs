﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountContract2.  ISO2002 ID# _UkZWQtp-Ed-ak6NoX_4Aeg_-1896166238.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target dates dates related to account opening and closing.
/// </summary>
public partial record AccountContract2
     : IIsoXmlSerilizable<AccountContract2>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related basic services are expected to be operational for the account owner.
    /// </summary>
    public IsoISODate? TargetGoLiveDate { get; init; } 
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    public IsoISODate? TargetClosingDate { get; init; } 
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    public IsoYesNoIndicator? UrgencyFlag { get; init; } 
    
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
        if (TargetGoLiveDate is IsoISODate TargetGoLiveDateValue)
        {
            writer.WriteStartElement(null, "TrgtGoLiveDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TargetGoLiveDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TargetClosingDate is IsoISODate TargetClosingDateValue)
        {
            writer.WriteStartElement(null, "TrgtClsgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TargetClosingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (UrgencyFlag is IsoYesNoIndicator UrgencyFlagValue)
        {
            writer.WriteStartElement(null, "UrgcyFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(UrgencyFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static AccountContract2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
