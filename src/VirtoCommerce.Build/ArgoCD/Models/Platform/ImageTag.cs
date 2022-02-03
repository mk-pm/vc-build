namespace VirtoCommerce.Build.ArgoCD.Models.Platform
{
    public class ImageTag : HelmParameter
    {
        public ImageTag(string value) : base(false, "platform.image.tag", value)
        {
        }
    }
}

