﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoginRequest4.  ISO2002 ID# _ze71QVE8EeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Request message.
/// </summary>
public partial record LoginRequest4
     : IIsoXmlSerilizable<LoginRequest4>
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    public required IsoISODateTime LoginDateTime { get; init; } 
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    public PointOfInteractionComponent12? SaleSoftware { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _zlGHo1E8EeyApZmLzm74zA
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    /// <summary>
    /// Training mode.
    /// </summary>
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    public IsoMax35Text? CashierIdentification { get; init; } 
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    public required LanguageCode CashierLanguage { get; init; } 
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    public PointOfInteractionComponentIdentification2? POIIdentification { get; init; } 
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    public ActionMessage9? OutputDisplay { get; init; } 
    
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
        writer.WriteStartElement(null, "LgnDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(LoginDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        // Not sure how to serialize SaleSoftware, multiplicity Unknown
        if (SaleTerminalData is SaleTerminalData1 SaleTerminalDataValue)
        {
            writer.WriteStartElement(null, "SaleTermnlData", xmlNamespace );
            SaleTerminalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TrainingModeFlag is IsoTrueFalseIndicator TrainingModeFlagValue)
        {
            writer.WriteStartElement(null, "TrngMdFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(TrainingModeFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CashierIdentification is IsoMax35Text CashierIdentificationValue)
        {
            writer.WriteStartElement(null, "CshrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CashierIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CshrLang", xmlNamespace );
        writer.WriteValue(CashierLanguage.ToString()); // Enum value
        writer.WriteEndElement();
        if (ShiftNumber is IsoMax2NumericText ShiftNumberValue)
        {
            writer.WriteStartElement(null, "ShftNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2NumericText(ShiftNumberValue)); // data type Max2NumericText System.String
            writer.WriteEndElement();
        }
        if (TokenRequestedType is SaleTokenScope1Code TokenRequestedTypeValue)
        {
            writer.WriteStartElement(null, "TknReqdTp", xmlNamespace );
            writer.WriteValue(TokenRequestedTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CustomerOrderRequest is CustomerOrderRequest1Code CustomerOrderRequestValue)
        {
            writer.WriteStartElement(null, "CstmrOrdrReq", xmlNamespace );
            writer.WriteValue(CustomerOrderRequestValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (POIIdentification is PointOfInteractionComponentIdentification2 POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            POIIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalsGroupIdentification is IsoMax35Text TotalsGroupIdentificationValue)
        {
            writer.WriteStartElement(null, "TtlsGrpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TotalsGroupIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OutputDisplay is ActionMessage9 OutputDisplayValue)
        {
            writer.WriteStartElement(null, "OutptDisp", xmlNamespace );
            OutputDisplayValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static LoginRequest4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
