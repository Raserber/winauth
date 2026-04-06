// Commenting out the export menu item for TOTP to enhance security
// exportOptionsMenuItem_Click();

// Replacement method to show security warning dialog
private void exportOptionsMenuItem_Click(object sender, EventArgs e) {
    MessageBox.Show("Warning: Exporting TOTP secrets can lead to credential leakage. Are you sure you want to proceed?", "Security Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
}