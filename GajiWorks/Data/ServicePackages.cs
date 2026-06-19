using GajiWorks.Models;

namespace GajiWorks.Data;

public static class ServicePackages
{
    public static IReadOnlyList<ServicePackage> All { get; } =
    [
        new("Quick Launch Page", "need one focused page for an offer or campaign", "A concise page that presents one clear offer and gives visitors an easy next step.", "A launch page for a new local service.", "01"),
        new("Business Starter Website", "need a professional online home", "A professional multi-section website for essential business information and customer inquiries.", "A website for a consultant or local shop.", "02"),
        new("Business Profile / Catalog", "want to present services or products clearly", "A structured website that helps visitors understand, browse, and inquire about your offerings.", "A supplier catalog with inquiry options.", "03"),
        new("Advanced Showcase", "have a larger portfolio or catalog", "A richer showcase with detailed categories, filtering, and content designed for confident decisions.", "A manufacturer presenting multiple product lines.", "04"),
        new("Business System", "want to improve daily operations", "A purpose-built browser-based system shaped around your workflow, records, and reporting needs.", "A job tracking or inventory portal.", "05"),
        new("Web Automation & Data Scraping", "want to reduce repetitive web tasks", "Practical automation that gathers, organizes, or moves approved business data more efficiently.", "A recurring market-price monitoring report.", "06")
    ];

    public static IReadOnlyList<PricingPackage> Pricing { get; } =
    [
        new("Quick Launch Page", "₱5,000 – ₱12,000", "A focused page for a new offer, service, or campaign."),
        new("Business Starter Website", "₱12,000 – ₱25,000", "A professional online presence with essential business details."),
        new("Business Profile / Catalog", "₱25,000 – ₱45,000", "A structured showcase for your business, services, or products.", true),
        new("Advanced Showcase", "₱45,000 – ₱90,000", "A richer portfolio or catalog for larger content needs."),
        new("Business System", "₱80,000+", "A tailored system designed around your business workflow."),
        new("Web Automation & Data Scraping", "Quote-based", "A scoped solution for repetitive web tasks and approved data collection.")
    ];
}
