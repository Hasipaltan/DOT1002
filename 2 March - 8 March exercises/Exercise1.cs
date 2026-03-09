public Text goldText;
public Text crystalText;
public Text foodText;
public Text woodText;
public Text stoneText;

void UpdateResource(Text resourceText, int amount)
{
    resourceText.text = "Amount: " + amount.ToString();
}