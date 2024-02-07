﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputData2.  ISO2002 ID# _svNbwQ0cEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an Input request.
/// </summary>
public partial record InputData2
     : IIsoXmlSerilizable<InputData2>
{
    #nullable enable
    
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    public required SaleCapabilities2Code DeviceType { get; init; } 
    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Type of requested input.
    /// </summary>
    public required InputCommand1Code InputCommand { get; init; } 
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 
    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    public IsoNumber? MaximumInputTime { get; init; } 
    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    public ActionMessage7? InputText { get; init; } 
    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 
    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 
    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 
    /// <summary>
    /// Flag to deactivate the "Cancel" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 
    /// <summary>
    /// Flag to deactivate the "Correct" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 
    /// <summary>
    /// Flag to disable the "Valid" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 
    /// <summary>
    /// Flag to enable the "Back" function key to go the upper level.
    /// </summary>
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 
    
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
        writer.WriteStartElement(null, "DvcTp", xmlNamespace );
        writer.WriteValue(DeviceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InfQlfr", xmlNamespace );
        writer.WriteValue(InformationQualifier.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InptCmd", xmlNamespace );
        writer.WriteValue(InputCommand.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NtfyCardInptFlg", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(NotifyCardInputFlag)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (MaximumInputTime is IsoNumber MaximumInputTimeValue)
        {
            writer.WriteStartElement(null, "MaxInptTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaximumInputTimeValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (InputText is ActionMessage7 InputTextValue)
        {
            writer.WriteStartElement(null, "InptTxt", xmlNamespace );
            InputTextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ImmediateResponseFlag is IsoTrueFalseIndicator ImmediateResponseFlagValue)
        {
            writer.WriteStartElement(null, "ImdtRspnFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ImmediateResponseFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (WaitUserValidationFlag is IsoTrueFalseIndicator WaitUserValidationFlagValue)
        {
            writer.WriteStartElement(null, "WaitUsrVldtnFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(WaitUserValidationFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (BeepKeyFlag is IsoTrueFalseIndicator BeepKeyFlagValue)
        {
            writer.WriteStartElement(null, "BeepKeyFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(BeepKeyFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (GlobalCorrectionFlag is IsoTrueFalseIndicator GlobalCorrectionFlagValue)
        {
            writer.WriteStartElement(null, "GblCrrctnFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(GlobalCorrectionFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (DisableCancelFlag is IsoTrueFalseIndicator DisableCancelFlagValue)
        {
            writer.WriteStartElement(null, "DsblCclFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DisableCancelFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (DisableCorrectFlag is IsoTrueFalseIndicator DisableCorrectFlagValue)
        {
            writer.WriteStartElement(null, "DsblCrrctFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DisableCorrectFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (DisableValidFlag is IsoTrueFalseIndicator DisableValidFlagValue)
        {
            writer.WriteStartElement(null, "DsblVldFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DisableValidFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (MenuBackFlag is IsoTrueFalseIndicator MenuBackFlagValue)
        {
            writer.WriteStartElement(null, "MenuBckFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(MenuBackFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static InputData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
