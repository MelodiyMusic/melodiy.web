import { IconProps } from '../types';
import { twMerge } from 'tailwind-merge';

function VideoIcon({ width = 50, height = 50, className }: Partial<IconProps>) {
  return (
    <svg xmlns="http://www.w3.org/2000/svg"
    width={width}
    height={height}
    className={twMerge('text-base-accent stroke-current', className)}
    fill="none"
    viewBox="0 0 41 42" >
      <rect width="21" height="17" stroke="stroke-current" stroke-linejoin="round" stroke-width="2" rx="4" transform="matrix(1 0 0 -1 10.508 29.248)"></rect><path fill="stroke-current" d="M18.508 18.057v5.382a.5.5 0 0 0 .724.447l5.382-2.69a.5.5 0 0 0 0-.895l-5.382-2.691a.5.5 0 0 0-.724.447Z"></path>
    </svg>
  );
}

export { VideoIcon };
