﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Collateral18.  ISO2002 ID# _96huocEaEea7jLfvGi1PDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security pledge as collateral.
/// </summary>
public partial record Collateral18
     : IIsoXmlSerilizable<Collateral18>
{
    #nullable enable
    
    /// <summary>
    /// Provides the values of the security pledged as collateral.
    /// </summary>
    public required SecuredCollateral2Choice_ Valuation { get; init; } 
    /// <summary>
    /// Risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// For reporting purposes the collateral haircut will be calculated as 100 minus the ratio between the cash lent/borrowed and the market value including accrued interest of the collateral pledged times 100. 
    /// In the case of multi-collateral repos the haircut will be based on the ratio between the cash borrowed/lent and the market value, including accrued interest of each of the individual collateral pledged. 
    /// Only actual values, as opposed to estimated or default values will be reported for this variable.
    /// </summary>
    public IsoPercentageRate? Haircut { get; init; } 
    /// <summary>
    /// Identifies all repurchase agreements conducted against general collateral, those conducted against special collateral and securities lending transactions made of matched repurchase agreements and reverse repurchase agreements transacted versus cash.
    /// - General Collateral is a repurchase transaction in which the security lender may choose the security to pledge as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria; 
    /// - Special Collateral is a repurchase transaction in which the cash provider requests a specific security (individual ISIN) to be provided by the cash borrower;
    /// - Matched and Reverse Repurchase Agreement is a securities lending transaction as defined by local market practices. 
    /// Usage:
    /// This field is optional and it should be provided only in case it is feasible for the reporting agent.
    /// </summary>
    public SpecialCollateral2Code? SpecialCollateralIndicator { get; init; } 
    
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
        writer.WriteStartElement(null, "Valtn", xmlNamespace );
        Valuation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Haircut is IsoPercentageRate HaircutValue)
        {
            writer.WriteStartElement(null, "Hrcut", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(HaircutValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (SpecialCollateralIndicator is SpecialCollateral2Code SpecialCollateralIndicatorValue)
        {
            writer.WriteStartElement(null, "SpclCollInd", xmlNamespace );
            writer.WriteValue(SpecialCollateralIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Collateral18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
