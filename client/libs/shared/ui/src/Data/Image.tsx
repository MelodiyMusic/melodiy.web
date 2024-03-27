import { getDefaultImage } from '../utils';
import { ImgHTMLAttributes, SyntheticEvent, forwardRef } from 'react';

interface ImageProps extends ImgHTMLAttributes<HTMLImageElement> {
  fallback?: string;
}

//Wrapper around nextimage to handle fallbacks by default
const Image = forwardRef<HTMLImageElement, ImageProps>(
  ({ src, fallback, alt, style, ...props }, ref) => {
    const handleError = (e: SyntheticEvent<HTMLImageElement, Event>) => {
      const fallbackSrc = fallback ?? getDefaultImage();
      e.currentTarget.src = fallbackSrc;
    };

    return (
      <div ref={ref}>
        <img
          style={{ objectFit: 'cover' }}
          src={src}
          alt={alt}
          onError={handleError}
          {...props}
        />
      </div>
    );
  }
);

Image.displayName = 'MelodiyImage';

export { Image };
