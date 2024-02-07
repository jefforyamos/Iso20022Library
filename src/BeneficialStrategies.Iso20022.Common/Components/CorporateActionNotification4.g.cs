﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNotification4.  ISO2002 ID# _se-jkSXZEeOFIcNWlDEvdQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event notification status and contents.
/// </summary>
public partial record CorporateActionNotification4
     : IIsoXmlSerilizable<CorporateActionNotification4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of notification.
    /// </summary>
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    public required CorporateActionProcessingStatus4Choice_ ProcessingStatus { get; init; } 
    /// <summary>
    /// Indicates whether the eligible balance is final except for a voluntary corporate action event where it can represent the current eligible balance when communicated before expiration date of that event.
    /// </summary>
    public IsoYesNoIndicator? EligibleBalanceIndicator { get; init; } 
    
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
        writer.WriteStartElement(null, "NtfctnTp", xmlNamespace );
        writer.WriteValue(NotificationType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
        ProcessingStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EligibleBalanceIndicator is IsoYesNoIndicator EligibleBalanceIndicatorValue)
        {
            writer.WriteStartElement(null, "ElgblBalInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EligibleBalanceIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNotification4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
