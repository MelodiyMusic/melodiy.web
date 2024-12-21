import { IconProps } from '../types';
import { twMerge } from 'tailwind-merge';

function ArrowLeftIcon({ width = 50, height = 50, className }: Partial<IconProps>) {
  return (
    <svg xmlns="http://www.w3.org/2000/svg"
    width={width}
    height={height}
    className={twMerge('text-base-accent stroke-current', className)}
    fill="none"
    viewBox="0 0 41 42" >
      <path stroke="stroke-current" stroke-linecap="round" stroke-linejoin="round" stroke-width="2.021" d="M28.458 20.628H14.146m0 0 5.893 5.893m-5.893-5.893 5.893-5.893"></path>
    </svg>
  );
}

export { ArrowLeftIcon };
