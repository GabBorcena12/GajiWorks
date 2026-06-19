using GajiWorks.Models;

namespace GajiWorks.Data;

public static class PortfolioProjects
{
    public static IReadOnlyList<PortfolioProject> All { get; } =
    [
        new("Northline Manufacturing", "Business Profile / Catalog", "A polished company profile that presents capabilities, certifications, and inquiry paths for prospective partners.", ["Responsive", "Business Profile", "Lead Generation"], ["Service overview", "Project gallery", "Quote inquiry"], ["Homepage", "Capabilities", "Inquiry Flow"], "₱25,000 – ₱45,000", "project-blue"),
        new("Harbor & Pine Living", "Advanced Showcase", "A calm, image-led furniture catalog designed to make collections easy to browse and compare.", ["Product Catalog", "Mobile Ready", "Visual Showcase"], ["Category browsing", "Product details", "Mobile catalog"], ["Collection View", "Product Details", "Mobile Catalog"], "₱45,000 – ₱90,000", "project-cyan"),
        new("LedgerPoint Advisory", "Business Starter Website", "A trust-focused service website that explains financial solutions clearly and drives consultation requests.", ["Professional Services", "Trust Focused", "Consultation"], ["Service pages", "Trust indicators", "Consultation form"], ["Service Overview", "Advisory Details", "Consultation Form"], "₱12,000 – ₱25,000", "project-violet"),
        new("SoleForm International", "Advanced Showcase", "An international orthopedic footwear showcase built around comfort, craftsmanship, and distributor support.", ["International", "Product Showcase", "Partner Support"], ["Product showcase", "Partner information", "Global inquiries"], ["Brand Story", "Product Range", "Partner Portal"], "₱45,000 – ₱90,000", "project-teal"),
        new("StockPilot", "Business System", "A focused business dashboard concept for monitoring stock, purchase activity, and low-quantity items.", ["Web Application", "Inventory", "Reporting"], ["Stock overview", "Activity tracking", "Business reports"], ["Dashboard", "Stock Records", "Reports"], "₱80,000+", "project-indigo"),
        new("FieldFlow Services", "Business System", "A lightweight operations portal concept that keeps requests, schedules, and job updates organized.", ["Operations", "Scheduling", "Status Tracking"], ["Request intake", "Schedule view", "Status updates"], ["Request Board", "Schedule", "Job Details"], "₱80,000+", "project-sky")
    ];
}
