﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption15.  ISO2002 ID# _CfMJYeGaEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
public partial record SecuritiesOption15
     : IIsoXmlSerilizable<SecuritiesOption15>
{
    #nullable enable
    
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; init; } 
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; init; } 
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    public FinancialInstrumentQuantity16Choice_? FrontEndOddLotQuantity { get; init; } 
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    public FinancialInstrumentQuantity16Choice_? BackEndOddLotQuantity { get; init; } 
    
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
        if (MaximumExercisableQuantity is FinancialInstrumentQuantity1Choice_ MaximumExercisableQuantityValue)
        {
            writer.WriteStartElement(null, "MaxExrcblQty", xmlNamespace );
            MaximumExercisableQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumExercisableQuantity is FinancialInstrumentQuantity1Choice_ MinimumExercisableQuantityValue)
        {
            writer.WriteStartElement(null, "MinExrcblQty", xmlNamespace );
            MinimumExercisableQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumExercisableMultipleQuantity is FinancialInstrumentQuantity1Choice_ MinimumExercisableMultipleQuantityValue)
        {
            writer.WriteStartElement(null, "MinExrcblMltplQty", xmlNamespace );
            MinimumExercisableMultipleQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewBoardLotQuantity is FinancialInstrumentQuantity1Choice_ NewBoardLotQuantityValue)
        {
            writer.WriteStartElement(null, "NewBrdLotQty", xmlNamespace );
            NewBoardLotQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewDenominationQuantity is FinancialInstrumentQuantity1Choice_ NewDenominationQuantityValue)
        {
            writer.WriteStartElement(null, "NewDnmtnQty", xmlNamespace );
            NewDenominationQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FrontEndOddLotQuantity is FinancialInstrumentQuantity16Choice_ FrontEndOddLotQuantityValue)
        {
            writer.WriteStartElement(null, "FrntEndOddLotQty", xmlNamespace );
            FrontEndOddLotQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BackEndOddLotQuantity is FinancialInstrumentQuantity16Choice_ BackEndOddLotQuantityValue)
        {
            writer.WriteStartElement(null, "BckEndOddLotQty", xmlNamespace );
            BackEndOddLotQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesOption15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
