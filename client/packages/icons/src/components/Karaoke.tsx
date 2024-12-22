import { IconProps } from '../types';
import { twMerge } from 'tailwind-merge';

function KaraokeIcon({ width = 50, height = 50, className }: Partial<IconProps>) {
  return (
    <svg xmlns="http://www.w3.org/2000/svg"
    width={width}
    height={height}
    className={twMerge('text-base-accent stroke-current', className)}
    fill="none"
    viewBox="0 0 41 42" >
      <g clip-path="url(#a)"><path stroke="stroke-current" stroke-width="1.684" d="M26.422 21.092a5.08 5.08 0 1 0-5.08-5.08m5.08 5.08a5.08 5.08 0 0 1-5.08-5.08m5.08 5.08-10.865 9.643a2.63 2.63 0 0 1-1.746.663 2.639 2.639 0 0 1-2.63-2.64c0-.635.229-1.253.644-1.733l9.517-11.013"></path></g><defs><clipPath id="a"><path fill="#fff" d="M9.497 9.248H33.07v23.573H9.497z"></path></clipPath></defs>
    </svg>
  );
}

export { KaraokeIcon };
